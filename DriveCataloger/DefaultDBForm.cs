using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace DriveCataloger
{
    public partial class defaultDBForm : Form
    {
        public defaultDBForm()
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

                conStr = "Database=" + dbNameTxt.Text + ";Server=" + serverTxt.Text +
                         ";port=" + portTxt.Text + ";Username=" + userNameTxt.Text +
                         ";Password=" + passTxt.Text + ";";
                MySqlConnection dbCon = new MySqlConnection(conStr);

                try
                {
                    // Try to open the connection
                    dbCon.Open();

                    // Save database settings in the config.cfg files
                    FileStream fs = new FileStream("config.cfg", FileMode.Create);
                    BinaryWriter writer = new BinaryWriter(fs);
                    writer.Write(dbNameTxt.Text);
                    writer.Write(serverTxt.Text);
                    writer.Write(portTxt.Text);
                    writer.Write(userNameTxt.Text);
                    writer.Write(passTxt.Text);
                    writer.Close();

                    MessageBox.Show("Default Database changed successfully");

                    // Close the connection
                    dbCon.Close();
                    dbCon.Dispose();

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

        private void defaultDBForm_Shown(object sender, EventArgs e)
        {
            if (Program.dbInit == true)
            {
                // Initialize fields with current database parameters
                dbNameTxt.Text = Program.dbName;
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
