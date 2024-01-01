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

namespace PROJET
{

    public partial class AdminPanelHome : Form
    {
        SqlConnection cnx = Program.Getconnection();
        public AdminPanelHome()
        {
            InitializeComponent();
        }

        private void AdminPanelHome_Load(object sender, EventArgs e)
        {
        // COUNT
            cnx.Open();
            // USER COUNT
            string UserCountQuery = $"SELECT count(*) as totalClients FROM client";
            SqlCommand UserCountcommand = new SqlCommand(UserCountQuery, cnx);
            int countUser = (int)UserCountcommand.ExecuteScalar();
            usrcountLBL.Text = countUser.ToString();
            // EVENT COUNT
            string EventCountQuery = $"SELECT count(*) as totalEvents FROM evenement";
            SqlCommand EventCountcommand = new SqlCommand(EventCountQuery, cnx);
            int countEvent = (int)EventCountcommand.ExecuteScalar();
            eventcountLBL.Text = countEvent.ToString();
            // TICKET COUNT
            string TicketCountQuery = $"SELECT count(*) as totalTicket FROM ticket";
            SqlCommand TicketCountcommand = new SqlCommand(TicketCountQuery, cnx);
            int countTicket = (int)TicketCountcommand.ExecuteScalar();
            ticketcountLBL.Text = countTicket.ToString();
        // LATEST
            cnx.Close();
        }
    }
}
