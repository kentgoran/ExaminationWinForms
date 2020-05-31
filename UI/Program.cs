using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        //ConnectionString can be input here, for ease of access later on.
        //Only put here for my teacher to easily change the connectionString
        static public string connectionString = @"Data Source=DESKTOP-21JF0EO\MSSQLSERVER01;Initial Catalog=MovieFestivalDatabase;Integrated Security=True";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
