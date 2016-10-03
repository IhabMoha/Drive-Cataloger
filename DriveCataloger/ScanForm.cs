using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DriveCataloger
{
    public partial class ScanForm : Form
    {
        private DriveInfo[] allDrives;
        private string cmdStr;
        private string tmpStr;
        private MySqlCommand sqlCmd;
        private string path;
        private double totSize;
        private long accSize;
        private struct archiveInformation
        {
            public long totFiles;
            public long totDirs;
            public long accessDenied;
        }
        private bool stopFlag;

        DateTime sto;
        DateTime eto;
        Int16 tco;
        int indx;

        Thread crawler;

        private archiveInformation archiveInfo = new archiveInformation();

        public ScanForm()
        {
            InitializeComponent();
        }

        private void scanForm_Load(object sender, EventArgs e)
        {
            ListViewItem item;
            // Get all drives
            allDrives = DriveInfo.GetDrives();

            // Search for all drives
            foreach (DriveInfo d in allDrives)
            {
                item = null;
                item = new ListViewItem();

                if (d.IsReady == true)
                {
                    item.Text = d.Name;
                    item.SubItems.Add(d.VolumeLabel);
                    item.SubItems.Add(d.DriveType.ToString());
                    item.SubItems.Add(d.DriveFormat);
                    item.SubItems.Add((d.TotalSize / 1048576).ToString() + "-MB");
                    item.SubItems.Add((d.TotalFreeSpace / 1048576).ToString() + "-MB");
                }
                else
                    item.Text = d.Name + " - Not ready";
                driveListView.Items.Add(item);
            }

            // Select the first drive
            driveListView.Items[0].Selected = true;
        }

        private void refreshBut_Click(object sender, EventArgs e)
        {
            // Clear all drives
            driveListView.Items.Clear();
            // Get all drives
            allDrives = DriveInfo.GetDrives();

            ListViewItem item;

            // Search for all drives
            foreach (DriveInfo d in allDrives)
            {
                item = null;
                item = new ListViewItem();

                if (d.IsReady == true)
                {
                    item.Text = d.Name;
                    item.SubItems.Add(d.VolumeLabel);
                    item.SubItems.Add(d.DriveType.ToString());
                    item.SubItems.Add(d.DriveFormat);
                    item.SubItems.Add((d.TotalSize / 1048576).ToString() + "-MB");
                    item.SubItems.Add((d.TotalFreeSpace / 1048576).ToString() + "-MB");
                }
                else
                    item.Text = d.Name + " - Not ready";
                driveListView.Items.Add(item);
            }

            // Select the first drive
            driveListView.Items[0].Selected = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            stopFlag = true;
            this.Close();
        }

        private void findAllFiles()
        {
            try
            {
                if (stopFlag == true)
                    return;
                DirectoryInfo dInfo = new DirectoryInfo(path);
                DirectoryInfo[] dirs = dInfo.GetDirectories();
                FileInfo[] files = dInfo.GetFiles();

                ++archiveInfo.totDirs;

                string corPath = path.Replace("\\", "\\\\");
                foreach (FileInfo fi in files)
                {
                    tmpStr = cmdStr;
                    tmpStr += "\"" + corPath + "\", ";
                    tmpStr += "\"" + fi.Name + "\", ";
                    tmpStr += "\"" + fi.Extension + "\", ";
                    tmpStr += fi.Length + ", ";
                    tmpStr += "'" + fi.Attributes.ToString().Replace(" ", "") + "', ";
                    tmpStr += "'" + fi.CreationTime.Year + "-" + fi.CreationTime.Month + "-" + fi.CreationTime.Day + "', ";
                    tmpStr += "'" + fi.CreationTime.Hour + ":" + fi.CreationTime.Minute + ":" + fi.CreationTime.Second + "', ";
                    tmpStr += "'" + fi.LastWriteTime.Year + "-" + fi.LastWriteTime.Month + "-" + fi.LastWriteTime.Day + "', ";
                    tmpStr += "'" + fi.LastWriteTime.Hour + ":" + fi.LastWriteTime.Minute + ":" + fi.LastWriteTime.Second + "'";
                    tmpStr += ")";
                    sqlCmd.CommandText = tmpStr;
                    sqlCmd.ExecuteNonQuery();

                    accSize += fi.Length;

                    ++archiveInfo.totFiles;
                }

                foreach (DirectoryInfo di in dirs)
                {
                    tmpStr = cmdStr;
                    tmpStr += "\"" + corPath + "\", ";
                    tmpStr += "\"" + di.Name + "\", ";
                    tmpStr += "'', ";
                    tmpStr += "0, ";
                    tmpStr += "'" + di.Attributes.ToString().Replace(" ", "") + "', ";
                    tmpStr += "'" + di.CreationTime.Year + "-" + di.CreationTime.Month + "-" + di.CreationTime.Day + "', ";
                    tmpStr += "'" + di.CreationTime.Hour + ":" + di.CreationTime.Minute + ":" + di.CreationTime.Second + "', ";
                    tmpStr += "'" + di.LastWriteTime.Year + "-" + di.LastWriteTime.Month + "-" + di.LastWriteTime.Day + "', ";
                    tmpStr += "'" + di.LastWriteTime.Hour + ":" + di.LastWriteTime.Minute + ":" + di.LastWriteTime.Second + "'";
                    tmpStr += ")";
                    sqlCmd.CommandText = tmpStr;
                    sqlCmd.ExecuteNonQuery();

                    path = di.FullName;
                    findAllFiles();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Don't have permission
                ++archiveInfo.accessDenied;
            }
            catch (ArgumentNullException ex)
            {
                // path is null
            }
            catch (ArgumentException ex)
            {
                // path is a zero-length string, contains only white space, or contains one or more invalid characters
            }
            catch (PathTooLongException ex)
            {
                // The specified path, file name, or both exceed the system-defined maximum length
                // on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters
            }
            catch (DirectoryNotFoundException ex)
            {
                // The specified path is invalid
            }
            catch (IOException ex)
            {
                // path is a file name
            }
        }

        private void okBtn_Click_1(object sender, EventArgs e)
        {
            indx = driveListView.SelectedIndices[0];

            if (allDrives[indx].IsReady)
            {
                // Disable other UI
                startBtn.Enabled = false;
                closeBtn.Enabled = false;
                refreshBtn.Enabled = false;

                try
                {
                    // Create a sql command
                    sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = Program.dbConnection;

                    // Get the tco value from table counter
                    sqlCmd.CommandText = "SELECT tco FROM counter";
                    MySqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    tco = sqlReader.GetInt16(0);
                    sqlReader.Close();

                    // Increment the tco
                    ++tco;

                    // Prepare the progress bar
                    catalogingProg.Value = 0;
                    catalogingProg.Maximum = 100;
                    totSize = (allDrives[indx].TotalSize - allDrives[indx].TotalFreeSpace);
                    accSize = 0;

                    // Prepare archive information
                    archiveInfo.totDirs = 0;
                    archiveInfo.totFiles = 0;
                    archiveInfo.accessDenied = 0;

                    // Initialize stopFlag to false (Don't stop archiving)
                    stopFlag = false;

                    // Prepare the insert sql query for files_info table
                    cmdStr = "INSERT INTO files_info (storage_id, path, name, extension, size, attributes, creation_date, creation_time, modification_date, modification_time) VALUES(" + tco + ", ";
                    path = allDrives[indx].RootDirectory.ToString();
                    //path = "D:\\ebooks";

                    // Initialize a new thread for crawling files of the specified storage unit
                    crawler = new Thread(this.findAllFiles);
                    crawler.Start();

                    // Record the start time
                    sto = DateTime.Now;

                    // Update the form UI
                    while (crawler.IsAlive)
                    {
                        totDirsTxt.Text = archiveInfo.totDirs.ToString();
                        totFilesTxt.Text = archiveInfo.totFiles.ToString();
                        catalogingProg.Value = Convert.ToInt32(accSize * 100 / totSize);
                        Application.DoEvents();
                    }

                    // Record the stop time
                    eto = DateTime.Now;

                    // Save the storage unit info in to table main
                    cmdStr = "INSERT INTO main (storage_id, storage_type, label, file_system_type, total_size, used_size, total_dirs_archived, total_files_archived) Values(" + tco + ", ";
                    cmdStr += "'" + allDrives[indx].DriveType + "', ";
                    cmdStr += "'" + labelTxt.Text + "', ";
                    cmdStr += "'" + allDrives[indx].DriveFormat + "', ";
                    cmdStr += allDrives[indx].TotalSize + ", ";
                    cmdStr += (allDrives[indx].TotalSize - allDrives[indx].TotalFreeSpace) + ", ";
                    cmdStr += archiveInfo.totDirs + ", ";
                    cmdStr += archiveInfo.totFiles;
                    cmdStr += ")";
                    sqlCmd.CommandText = cmdStr;
                    sqlCmd.ExecuteNonQuery();

                    // Update the table counter tco value
                    sqlCmd.CommandText = "UPDATE counter SET tco=" + tco;
                    sqlCmd.ExecuteNonQuery();

                    // Display the results including
                    // time consumed in the process
                    // number of archived directories
                    // number of archived files
                    // number of access denied errors

                    // Note: change this msgboxes to form for displaying results, and could be on same form by using
                    // a hidden controls
                    TimeSpan ts = eto.Subtract(sto);
                    MessageBox.Show("Finished Successfult \n- Time consumed is-> M: " + ts.Minutes + "  S: " + ts.Seconds + "  MS: " + ts.Milliseconds);
                    MessageBox.Show("Number of archived directories: " + archiveInfo.totDirs + "  Number of archived files: " + archiveInfo.totFiles + "  Number of access-denied: " + archiveInfo.accessDenied);

                    // Reset the progress bar
                    catalogingProg.Value = 0;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message + " - " + tmpStr);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + " - " + tmpStr);
                }

                // Enable other UI
                startBtn.Enabled = true;
                closeBtn.Enabled = true;
                refreshBtn.Enabled = true;
            }
            else
                MessageBox.Show("Drive Not Ready");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopFlag = true;
        }

        private void ScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopFlag = true;
        }
    }
}
