using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    
    public partial class ViewUserTicket : Form
    {
        
        DataSet dataSet;  
        SqlCommandBuilder builder;
        BindingManagerBase bindingManager;
        SqlConnection cnx = Program.Getconnection();
        DataTable dt;


        public void SearchData(int userid)
        {
            string query = "SELECT nom_event, count(ticketID) as Ticket_Count FROM evenement E inner join ticket T on E.eventID = T.eventID where T.clientID = @client GROUP BY nom_event";

            cnx = Program.Getconnection();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@client", userid);
            cnx.Open();

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

        public ViewUserTicket(int userID)
        {
            InitializeComponent();
            SearchData(userID);
        }
    }
}
