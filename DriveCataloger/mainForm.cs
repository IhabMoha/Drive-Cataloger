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

namespace DriveCataloger
{
    public partial class mainForm : Form
    {
        private NewDBForm newDBFrm;
        private ChgDBForm chgDBFrm;
        private ScanForm scanFrm;
        private SearchForm searchFrm;
        private defaultDBForm defaultDBFrm;
        private ShowDBInfoForm showDBInfoFrm;

        private void chgMenusStatus()
        {
            catalogADriverToolStripMenuItem.Enabled = Program.dbInit;
            searchDatabaseToolStripMenuItem.Enabled = Program.dbInit;
            resetCurrentDatabaseToolStripMenuItem.Enabled = Program.dbInit;
            deleteCurrentDatabaseToolStripMenuItem.Enabled = Program.dbInit;
            showCurrentDatabaseInformationToolStripMenuItem.Enabled = Program.dbInit; ;
        }

        public mainForm()
        {
            InitializeComponent();

            // Create forms
            newDBFrm = new NewDBForm();
            chgDBFrm = new ChgDBForm();
            scanFrm = new ScanForm();
            searchFrm = new SearchForm();
            defaultDBFrm = new defaultDBForm();
            showDBInfoFrm = new ShowDBInfoForm();

            // Initialize database connection
            Program.dbConnection = new MySqlConnection();

            // Disable menus
            Program.dbInit = false;
            chgMenusStatus();

            if (File.Exists("config.cfg") == true)
            {
                // Read database parameters from config.cfg
                FileStream fs = new FileStream("config.cfg", FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);

                Program.dbName = reader.ReadString();
                Program.dbServer = reader.ReadString();
                Program.dbPort = reader.ReadString();
                Program.dbUsername = reader.ReadString();
                Program.dbPassword = reader.ReadString();

                reader.Close();

                // Set connection parameters
                string conStr = "Database=" + Program.dbName + ";Server=" + Program.dbServer +
                         ";port=" + Program.dbPort + ";Username=" + Program.dbUsername +
                         ";Password=" + Program.dbPassword + ";";
                Program.dbConnection.ConnectionString = conStr;

                try
                {
                    Program.dbConnection.Open();

                    // Enable menus
                    Program.dbInit = true;
                    chgMenusStatus();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error - 'config.cfg' file does not exists, if this is the first time you run the software then create a new database and set it as the default one, if it is not then the default settings are lost with the file, change the current database and set it as the default", "Missing Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDBFrm.ShowDialog();
        }

        private void catalogADriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scanFrm.ShowDialog();
        }

        private void changeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chgDBFrm.ShowDialog();
            chgMenusStatus();
        }

        private void searchDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFrm.ShowDialog();
        }

        private void setDefaultDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultDBFrm.ShowDialog();
        }

        private void resetCurrentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning, Database will be reset and all data will be lost",
                               "Reseting Current Database", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlCommand sqlCmd;

                try
                {
                    // Delete all data in the main table
                    sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = Program.dbConnection;
                    sqlCmd.CommandText = "TRUNCATE TABLE main";
                    sqlCmd.ExecuteNonQuery();

                    // Delete all data in the files_info table
                    sqlCmd.CommandText = "TRUNCATE TABLE files_info";
                    sqlCmd.ExecuteNonQuery();

                    // Delete all data in the counter table
                    sqlCmd.CommandText = "TRUNCATE TABLE counter";
                    sqlCmd.ExecuteNonQuery();

                    // Initialize the table counter to 0
                    sqlCmd.CommandText = "INSERT INTO counter (tco) VALUES(0);";
                    sqlCmd.ExecuteNonQuery();

                    // Close command and connection
                    sqlCmd.Dispose();

                    MessageBox.Show("Database reset successfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
        }

        private void deleteCurrentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning, Database will be deleted with all the data",
                               "Deleting Current Database", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlCommand sqlCmd = null;

                try
                {
                    // Delete all data in the main table
                    sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = Program.dbConnection;
                    sqlCmd.CommandText = "DROP DATABASE " + Program.dbName;
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Database deleted successfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    // Close command and connection
                    sqlCmd.Dispose();

                    // Close the database connection
                    Program.dbConnection.Close();

                    // Disable sub menus
                    Program.dbInit = false;
                    chgMenusStatus();
                }

            }
        }

        private void showCurrentDatabaseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDBInfoFrm.ShowDialog();
        }
    }
}
