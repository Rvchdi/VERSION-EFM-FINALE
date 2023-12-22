using MySql.Data.MySqlClient;
namespace PROJET

{
    internal static class Program
    {
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
        public static MySqlConnection Getconnection()
        {
            string strcnx = @"server=localhost; database=efm; uid=root";
            MySqlConnection cnx = new MySqlConnection(strcnx);
            return cnx;
        }
    }
}