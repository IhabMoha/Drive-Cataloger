using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DriveCataloger
{
    public partial class ShowDBInfoForm : Form
    {
        private Int16 totDrives;
        private Int16 curDrive;
        private MySqlCommand sqlCmd;
        private MySqlDataReader sqlReader;

        public ShowDBInfoForm()
        {
            InitializeComponent();
            totDrives = 0;
            curDrive = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDBInfoForm_Shown(object sender, EventArgs e)
        {
            prevBtn.Enabled = false;
            nextBtn.Enabled = false;

            try
            {
                // Get the number of cataloged drives from table counter
                sqlCmd = new MySqlCommand();
                sqlCmd.Connection = Program.dbConnection;
                sqlCmd.CommandText = "SELECT tco FROM counter";
                sqlReader = sqlCmd.ExecuteReader();
                sqlReader.Read();
                totDrives = sqlReader.GetInt16(0);
                catDrivesTotNuLabel.Text = totDrives.ToString();
                sqlReader.Close();

                // Get the first cataloged drive information
                curDrive = 1;
                sqlCmd.CommandText = "SELECT * FROM main WHERE storage_id=" + curDrive;
                sqlReader = sqlCmd.ExecuteReader();
                sqlReader.Read();
                
                driveNuLabel.Text = curDrive.ToString();
                driveLabel.Text = sqlReader.GetString("label");
                driveTypeLabel.Text = sqlReader.GetString("storage_type");
                fileTypeLabel.Text = sqlReader.GetString("file_system_type");
                driveTotSizeLabel.Text = sqlReader.GetString("total_size") + "  Bytes";
                driveUsedSizeLabel.Text = sqlReader.GetString("used_size") + "  Bytes";
                driveTotDirsLabel.Text = sqlReader.GetString("total_dirs_archived");
                driveTotFilesLabel.Text = sqlReader.GetString("total_files_archived");
                sqlReader.Close();

                // Enable next drive if there is one
                if (totDrives > 1)
                    nextBtn.Enabled = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            
            --curDrive;
            sqlCmd.CommandText = "SELECT * FROM main WHERE storage_id=" + curDrive;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();

            driveNuLabel.Text = curDrive.ToString();
            driveLabel.Text = sqlReader.GetString("label");
            driveTypeLabel.Text = sqlReader.GetString("storage_type");
            fileTypeLabel.Text = sqlReader.GetString("file_system_type");
            driveTotSizeLabel.Text = sqlReader.GetString("total_size") + "  Bytes";
            driveUsedSizeLabel.Text = sqlReader.GetString("used_size") + "  Bytes";
            driveTotDirsLabel.Text = sqlReader.GetString("total_dirs_archived");
            driveTotFilesLabel.Text = sqlReader.GetString("total_files_archived");
            sqlReader.Close();

            nextBtn.Enabled = true;

            if(curDrive <= 1)
            {
                prevBtn.Enabled = false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            
            ++curDrive;
            sqlCmd.CommandText = "SELECT * FROM main WHERE storage_id=" + curDrive;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();

            driveNuLabel.Text = curDrive.ToString();
            driveLabel.Text = sqlReader.GetString("label");
            driveTypeLabel.Text = sqlReader.GetString("storage_type");
            fileTypeLabel.Text = sqlReader.GetString("file_system_type");
            driveTotSizeLabel.Text = sqlReader.GetString("total_size") + "  Bytes";
            driveUsedSizeLabel.Text = sqlReader.GetString("used_size") + "  Bytes";
            driveTotDirsLabel.Text = sqlReader.GetString("total_dirs_archived");
            driveTotFilesLabel.Text = sqlReader.GetString("total_files_archived");
            sqlReader.Close();

            prevBtn.Enabled = true;
            
            if (curDrive >= totDrives)
            {
                nextBtn.Enabled = false;
            }
        }
    }
}
