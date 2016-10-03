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
    public partial class NewDBForm : Form
    {
        public NewDBForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // Remove all leadding and trailing white spaces
            dbNameTxt.Text = dbNameTxt.Text.Trim();
            serverTxt.Text = serverTxt.Text.Trim();
            portTxt.Text = portTxt.Text.Trim();
            userNameTxt.Text = userNameTxt.Text.Trim();
            passTxt.Text = passTxt.Text.Trim();

            // Ensure the user have fill in all the fields
            if (dbNameTxt.Text == "")
            {
                MessageBox.Show("Please, fill in the database name field", "Missing Database Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dbNameTxt.Focus();
            }
            else if (serverTxt.Text == "")
            {
                MessageBox.Show("Please, fill in the server field", "Missing Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                serverTxt.Focus();
            }
            else if (portTxt.Text == "")
            {
                MessageBox.Show("Please, fill in the port field", "Missing Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (userNameTxt.Text == "")
            {
                MessageBox.Show("Please, fill in the user name field", "Missing User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (passTxt.Text == "")
            {
                MessageBox.Show("Please, fill in the password field", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // User did fill in all fields so, make sure the database and it's connection are correct
                string conStr;
                MySqlConnection dbCon;

                MySqlCommand sqlCmd;

                conStr = "Server=" + serverTxt.Text + ";Username=" + userNameTxt.Text + ";Password=" +
                         passTxt.Text + ";port=" + portTxt.Text + ";";
                dbCon = new MySqlConnection(conStr);

                try
                {
                    // Try to open the connection
                    dbCon.Open();

                    // Create the new database and drop an exception if error occure
                    sqlCmd = new MySqlCommand();
                    sqlCmd.CommandText = "Create DATABASE " + dbNameTxt.Text;
                    sqlCmd.Connection = dbCon;
                    sqlCmd.ExecuteNonQuery();

                    //Select the new database
                    sqlCmd.CommandText = "USE " + dbNameTxt.Text + ";";
                    sqlCmd.ExecuteNonQuery();

                    // Create the counter table
                    sqlCmd.CommandText = "CREATE TABLE `counter` ( `tco` SMALLINT(5) UNSIGNED NOT NULL UNIQUE) ENGINE=InnoDB;";
                    sqlCmd.ExecuteNonQuery();

                    // Create the main table
                    sqlCmd.CommandText = "CREATE TABLE `main` (`storage_id` SMALLINT(5) UNSIGNED NOT NULL, " +
                                         "`storage_type` CHAR(15) NOT NULL, " +
                                         "`label` CHAR(50) NOT NULL, " +
                                         "`file_system_type` CHAR(10) NOT NULL, " +
                                         "`total_size` BIGINT(20) UNSIGNED NOT NULL, " +
                                         "`used_size` BIGINT(20) UNSIGNED NOT NULL, " +
                                         "`total_dirs_archived` BIGINT(20) UNSIGNED NOT NULL, " +
                                         "`total_files_archived` BIGINT(20) UNSIGNED NOT NULL, " +
                                         "PRIMARY KEY (`storage_id`) ) ENGINE=InnoDB;";
                    sqlCmd.ExecuteNonQuery();

                    // Create the files_info table
                    sqlCmd.CommandText = "CREATE TABLE `files_info` (`storage_id` smallint(5) unsigned NOT NULL, " +
                                         "`path` text NOT NULL, " +
                                         "`name` text NOT NULL, " +
                                         "`extension` varchar(255) default NULL, " +
                                         "`size` bigint(20) unsigned default NULL, " +
                                         //"`attributes` set('ReadOnly','Hidden','System','Directory','Archive','Device','Normal','Temporary','Sparse File','Reparse Point','Compressed','NotContentIndexed','Encrypted') default NULL, " +
                                         "`attributes` text default NULL, " +
                                         "`creation_date` date default NULL, " +
                                         "`creation_time` time default NULL, " +
                                         "`modification_time` time default NULL, " +
                                         "`modification_date` date default NULL ) " +
                                         "ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                    sqlCmd.ExecuteNonQuery();

                    // Initialize the table counter to 0
                    sqlCmd.CommandText = "INSERT INTO counter (tco) VALUES(0);";
                    sqlCmd.ExecuteNonQuery();

                    // Close connection
                    dbCon.Close();
                    dbCon.Dispose();
                    sqlCmd.Dispose();

                    MessageBox.Show("Database created successfully");

                    // Close this form
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 0)
                    {
                        MessageBox.Show("Error, Can not connect to MySQL server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (ex.Number == 1045)
                    {
                        MessageBox.Show("Error, Invalid username and/or Password", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                createBtn_Click(sender, null);
        }

        private void NewDBForm_Shown(object sender, EventArgs e)
        {
            if (Program.dbInit == true)
            {
                // Initialize fields with current database parameters
                serverTxt.Text = Program.dbServer;
                portTxt.Text = Program.dbPort;
                userNameTxt.Text = Program.dbUsername;
                passTxt.Text = Program.dbPassword;
            }
            else
            {
                // Initialize fields with default parameters
                serverTxt.Text = "localhost";
                portTxt.Text = "3306";
            }
        }

    }
}
