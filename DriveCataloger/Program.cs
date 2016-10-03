using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DriveCataloger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // MySQL public information required for connection
        public static string dbName;
        public static string dbServer;
        public static string dbPort;
        public static string dbUsername;
        public static string dbPassword;
        public static MySqlConnection dbConnection;

        public static bool dbInit;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
