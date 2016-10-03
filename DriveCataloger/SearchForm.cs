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
    public partial class SearchForm : Form
    {
        private ResultsForm resultsFrm;

        public SearchForm()
        {
            InitializeComponent();

            // Initialization
            fileAttributiesCombo.SelectedIndex = 4;
            fileSizeCombo.SelectedIndex = 0;
            fileCDateCombo.SelectedIndex = 0;
            fileMDateCombo.SelectedIndex = 0;
            fileCTimeCombo.SelectedIndex = 0;
            fileMTimeCombo.SelectedIndex = 0;

            fileNameGroup.Enabled = false;
            fileExtensionGroup.Enabled = false;
            fileAttributiesGroup.Enabled = false;
            fileSizeGroup.Enabled = false;
            fileCreationDateGroup.Enabled = false;
            fileModificationDateGroup.Enabled = false;
            fileCreationTimeGroup.Enabled = false;
            fileModificationTimeGroup.Enabled = false;

            resultsFrm = new ResultsForm();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Remove all leadding and trailing white spaces
            fileNameTxt.Text = fileNameTxt.Text.Trim();
            fileExtensionTxt.Text.Trim();
            fileSizeTxt.Text.Trim();
            fileCDateTxt.Text.Trim();
            fileMDateTxt.Text.Trim();
            fileCTimeTxt.Text.Trim();
            fileMTimeTxt.Text.Trim();

            // Ensure the user have fill in all the fields
            string sqlReq = "";
            bool goSearch = true;

            if ( fileNameGroup.Enabled == true )
            {
                if (fileNameTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file name field", "Missing File Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if(sqlReq == "")
                        sqlReq += "name LIKE '" + fileNameTxt.Text + "'";
                    else
                        sqlReq += " AND name LIKE '" + fileNameTxt.Text + "'";
                }
            }
            if (fileExtensionGroup.Enabled == true)
            {
                if (fileExtensionTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file extension field", "Missing File Extension", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if(sqlReq == "")
                        sqlReq += "extension='" + fileExtensionTxt.Text + "'";
                    else
                        sqlReq += " AND extension='" + fileExtensionTxt.Text + "'";
                }
            }
            if( (fileAttributiesGroup.Enabled == true) )
            {
                if (sqlReq == "")
                    sqlReq += "attributes='" + fileAttributiesCombo.SelectedText + "'";
                else
                    sqlReq += " AND attributes='" + fileAttributiesCombo.SelectedText + "'";
            }
            if (fileSizeGroup.Enabled == true)
            {
                if (fileSizeTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file size field", "Missing File Size", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if (sqlReq == "")
                        sqlReq += "size";
                    else
                        sqlReq += " AND size";

                    if (fileSizeCombo.SelectedText == "Specific Size:")
                    {
                        sqlReq += "=='" + fileSizeTxt.Text + "'";
                    }
                    else if (fileSizeCombo.SelectedText == "Greater than:")
                    {
                        sqlReq += ">" + fileSizeTxt.Text;
                    }
                    else if (fileSizeCombo.SelectedText == "Less than:")
                    {
                        sqlReq += "<" + fileSizeTxt.Text;
                    }
                }
            }
            if (fileCreationDateGroup.Enabled == true)
            {
                if (fileCDateTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file creation date field", "Missing File Creation Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if (sqlReq == "")
                        sqlReq += "creation_date='" + fileCDateTxt.Text + "'";
                    else
                        sqlReq += " AND creation_date='" + fileCDateTxt.Text + "'";
                }
            }
            if (fileModificationDateGroup.Enabled == true)
            {
                if (fileMDateTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file modification date field", "Missing File Modification Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if (sqlReq == "")
                        sqlReq += "modification_date='" + fileMDateTxt.Text + "'";
                    else
                        sqlReq += " AND modification_date='" + fileMDateTxt.Text + "'";
                }
            }
            if (fileCreationTimeGroup.Enabled == true)
            {
                if (fileCTimeTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file creation time field", "Missing File Creation Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if (sqlReq == "")
                        sqlReq += "creation_time='" + fileCTimeTxt.Text + "'";
                    else
                        sqlReq += " AND creation_time='" + fileCTimeTxt.Text + "'";
                }
            }
            if (fileModificationTimeGroup.Enabled == true)
            {
                if (fileMDateTxt.Text == "")
                {
                    MessageBox.Show("Please, fill in the file modification time field", "Missing File Modification Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goSearch = false;
                }
                else
                {
                    if (sqlReq == "")
                        sqlReq += "modification_time='" + fileMTimeTxt.Text + "'";
                    else
                        sqlReq += " AND modification_time='" + fileMTimeTxt.Text + "'";
                }
            }

            if(goSearch == true)
            {
                // User did fill in all fields so, make sure the database and it's connection are correct
                MySqlCommand sqlCmd;

                try
                {
                    // Create the new database and drop an exception if error occure
                    sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = Program.dbConnection;

                    if(sqlReq == "")
                        sqlCmd.CommandText = "SELECT * FROM files_info";
                    else
                        sqlCmd.CommandText = "SELECT * FROM files_info WHERE " + sqlReq;

                    ListViewItem item;
                    MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    // Reset result list view
                    resultsFrm.resultsListView.Items.Clear();

                    while (sqlReader.Read())
                    {
                        item = null;
                        item = new ListViewItem();

                        item.Text = sqlReader.GetInt16("storage_id").ToString();
                        item.SubItems.Add(sqlReader.GetString("path"));
                        item.SubItems.Add(sqlReader.GetString("name"));
                        item.SubItems.Add(sqlReader.GetString("extension"));
                        item.SubItems.Add(sqlReader.GetUInt64("size").ToString());
                        item.SubItems.Add(sqlReader.GetString("attributes"));

                        item.SubItems.Add(sqlReader.GetDateTime("creation_date").ToShortDateString());
                        item.SubItems.Add(sqlReader.GetDateTime("modification_date").ToShortDateString());
                        // Can't get the time as a DateTime because there are no date, only time !!!
                        item.SubItems.Add(sqlReader.GetString("creation_time"));
                        item.SubItems.Add(sqlReader.GetString("modification_time"));

                        resultsFrm.resultsListView.Items.Add(item);
                    }
                    resultsFrm.ShowDialog();
                    sqlReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fileNameChk_CheckedChanged(object sender, EventArgs e)
        {
            fileNameGroup.Enabled = fileNameChk.Checked;
        }

        private void fileExtensionChk_CheckedChanged(object sender, EventArgs e)
        {
            fileExtensionGroup.Enabled = fileExtensionChk.Checked;
        }

        private void fileAttributesChk_CheckedChanged(object sender, EventArgs e)
        {
            fileAttributiesGroup.Enabled = fileAttributesChk.Checked;
        }

        private void fileSizeChk_CheckedChanged(object sender, EventArgs e)
        {
            fileSizeGroup.Enabled = fileSizeChk.Checked;
        }

        private void fileCDateChk_CheckedChanged(object sender, EventArgs e)
        {
            fileCreationDateGroup.Enabled = fileCDateChk.Checked;
        }

        private void fileMDateChk_CheckedChanged(object sender, EventArgs e)
        {
            fileModificationDateGroup.Enabled = fileMDateChk.Checked;
        }

        private void fileCTimeChk_CheckedChanged(object sender, EventArgs e)
        {
            fileCreationTimeGroup.Enabled = fileCTimeChk.Checked;
        }

        private void fileMTimeChk_CheckedChanged(object sender, EventArgs e)
        {
            fileModificationTimeGroup.Enabled = fileMTimeChk.Checked;
        }

    }
}
