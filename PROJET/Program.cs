using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data.SqlClient;
namespace PROJET

{
    internal static class Program
    {
        public static class loggedUser {
            public static string username { get; set; }
        }
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static SqlConnection Getconnection()
        {
            string strcnx = @"server=192.168.0.187; database=efm; uid=sa; password=heklilinifi1523; TrustServerCertificate=True";
            SqlConnection cnx = new SqlConnection(strcnx);
            return cnx;
        }
        
    }
}