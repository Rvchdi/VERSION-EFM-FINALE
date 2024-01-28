using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJET.AdminEVENT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class BuyTicketForm : Form
    {
        SqlConnection cnx = Program.Getconnection();
        private string eventid;
        private string user = Session.user;
        private string sport;
        public BuyTicketForm(int eventID)
        {
            InitializeComponent();
            eventid = eventID.ToString();
            quantityCB.SelectedItem = 2;
        }
        public void imgLoad(string sport)
        {
            try
            {
                string imageName = sport.ToLower() + ".jpeg";
                
                System.Drawing.Bitmap image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);

                if (image != null)
                {
                    PictureBox.Image = image;
                }
                else
                {
                    PictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void BuyTicketForm_Load(object sender, EventArgs e)
        {

            quantityCB.Items.Clear();
            for (int i = 1; i <= 4; i++)
            {
                quantityCB.Items.Add(i);
            }

            int numberOfTickets;
            int capacity;
            string Countquery = "select count(*) from ticket T inner join evenement E on T.eventID = E.eventID WHERE E.eventID=@id";
            using (SqlCommand countCommand = new SqlCommand(Countquery, cnx))
            {
                countCommand.Parameters.AddWithValue("@id", eventid);

                cnx.Open();

                numberOfTickets = (int)countCommand.ExecuteScalar();

                cnx.Close();
            }
            //////////////////////////
            string stadiumCapacity = "select nb_places from stade ST inner join evenement E on ST.stadiumID = E.stadiumID WHERE E.eventID=@id";
            using (SqlCommand countCommand = new SqlCommand(stadiumCapacity, cnx))
            {
                countCommand.Parameters.AddWithValue("@id", eventid);

                cnx.Open();

                capacity = (int)countCommand.ExecuteScalar();

                cnx.Close();
            }
            RemainingLBL.Text = (capacity - numberOfTickets).ToString();

            string query = "select * from evenement E inner join  sport S on E.sportID = S.sportID inner join  stade ST on E.stadiumID=ST.stadiumID WHERE E.eventID ='" + eventid + "'";
            cnx.Open();
            SqlCommand command = new SqlCommand(query, cnx);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                eventTITLE.Text = reader.GetString("nom_event");
                sportLBL.Text = reader.GetString("nom_sport");
                sport = reader.GetString("nom_sport").ToLower();
                dateLBL.Text = reader.GetDateTime(reader.GetOrdinal("event_DATE")).ToShortDateString();
                stadiumLBL.Text = reader.GetString("nom_stade");
            }
            cnx.Close();
            imgLoad(sport);

        }

        public int CheckTickets(int userID)
        {
            int count;
            string query = "select count(*) FROM ticket T inner join evenement E on T.eventID=E.eventID WHERE clientID=@id AND E.eventID=@event";
            using (SqlCommand countCommand = new SqlCommand(query, cnx))
            {
                countCommand.Parameters.AddWithValue("@id", userID);
                countCommand.Parameters.AddWithValue("@event", eventid);

                cnx.Open();

                count = (int)countCommand.ExecuteScalar();

                cnx.Close();
            }

            return Convert.ToInt32(count);
        }
        private void buyBTN_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt16(quantityCB.Text);
            int client = Convert.ToInt32(user);
            string evnt = eventid;
            string query = "INSERT INTO ticket(clientID, eventID) VALUES(@client, @event)";
            int limit = 4;
            int count;
            //MessageBox.Show($"{CheckTickets(user)}", "Achat refuse", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (limit - (CheckTickets(Convert.ToInt32(user)) + quantity) >= 0) {
                while (true)
                {
                    cnx.Open();
                    for (int i = 0; i < quantity; i++)
                    {
                        
                        SqlCommand cmd = new SqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@client", client);
                        cmd.Parameters.AddWithValue("@event", evnt);
                        cmd.ExecuteNonQuery();
                        
                        
                    }
                    cnx.Close();
                    MessageBox.Show("Achat accomplie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                }
            } else if (limit - (CheckTickets(Convert.ToInt32(user)) + quantity) < 0){
                MessageBox.Show("Limite d'achat de tickets atteinte", "Achat refuse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            
       
     
        }
            


}



