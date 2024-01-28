using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace PROJET
{
    public partial class MyTicketsFORMcs : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        BindingManagerBase bindingManager;
        
        DataTable dt;
        string user = Session.user;
        public MyTicketsFORMcs()
        {
            SqlConnection cnx = Program.Getconnection();
            InitializeComponent();
             string query = "SELECT E.eventID, nom_event, nom_sport, nom_stade, event_DATE " +
               "FROM evenement E " +
               "INNER JOIN sport S ON E.sportID = S.sportID " +
               "INNER JOIN stade ST ON E.stadiumID = ST.stadiumID " +
               "INNER JOIN ticket T ON T.eventID = E.eventID " +
               "INNER JOIN client C ON C.clientID = T.clientID " +
               "WHERE T.clientID = @ID";
            ;
            cnx.Open();
            SqlCommand cmd = new SqlCommand(query,cnx);
            cmd.Parameters.AddWithValue("@ID",user);
            using (cmd)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DataGrid.DataSource = dataTable;
                }
            }
            cnx.Close();


        }
        private void DataLoad(string query)
        {

           
        }
    }
}
