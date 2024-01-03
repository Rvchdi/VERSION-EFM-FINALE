using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class AdminEVENT : Form
    {
        SqlConnection cnx = Program.Getconnection();
        
        public AdminEVENT()
        {
            InitializeComponent();
        }
        public class Sport
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Stadium
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private void formLoad() {
            cnx = Program.Getconnection();
            using (cnx)
            {
                try
                {
                    cnx.Open();
                    string sql = "SELECT nom_event as Event_Name,nom_sport as Sport,nom_stade as Stadium,event_Date FROM sport S INNER JOIN  evenement E on S.sportID=E.sportID INNER JOIN  stade ST on st.stadiumID=E.stadiumID";
                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable eventsTable = new DataTable();
                    adapter.Fill(eventsTable);
                    datagrid.DataSource = eventsTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
                finally { cnx.Close(); }

            }
        }
        private void AdminEVENT_Load(object sender, EventArgs e)
        {

            string Stadiumquery = "SELECT stadiumID,nom_stade FROM stade";
            List<Stadium> stadiums = new List<Stadium>();
            string Sportquery = "SELECT sportID,nom_sport FROM sport";
            List<Sport> sports = new List<Sport>();
            using (cnx)
            {
                cnx.Open();
                // SPORT COMBOBOX VALUE LOADING
                using (SqlCommand SportQuerycommand = new SqlCommand(Sportquery, cnx))
                {
                    using (SqlDataReader Sportreader = SportQuerycommand.ExecuteReader())
                    {
                        while (Sportreader.Read())
                        {
                            sports.Add(new Sport
                            {
                                Id = Sportreader.GetInt32(0),
                                Name = Sportreader.GetString(1)
                            });
                        }
                    }
                }
                // STADIUM COMBOBOX VALUE LOADING
                using (SqlCommand StadiumQuerycommand = new SqlCommand(Stadiumquery, cnx))
                {
                    using (SqlDataReader Stadiumreader = StadiumQuerycommand.ExecuteReader())
                    {
                        while (Stadiumreader.Read())
                        {
                            stadiums.Add(new Stadium
                            {
                                Id = Stadiumreader.GetInt32(0),
                                Name = Stadiumreader.GetString(1)
                            });
                        }
                    }
                }
                cnx.Close();

            }
            SportCombo.DataSource = sports;
            SportCombo.DisplayMember = "Name";
            SportCombo.ValueMember = "Id";
            StadiumCombo.DataSource = stadiums;
            StadiumCombo.DisplayMember = "Name";
            StadiumCombo.ValueMember = "Id";
            // Load the list view with events
            cnx = Program.Getconnection();
            using (cnx)
            {
                try
                {
                    cnx.Open();
                    string sql = "SELECT nom_event as Event_Name , nom_sport as Sport,nom_stade as Stadium,event_Date as Event_Date FROM sport S INNER JOIN  evenement E on S.sportID=E.sportID INNER JOIN  stade ST on st.stadiumID=E.stadiumID";
                    SqlCommand command = new SqlCommand(sql, cnx);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable eventsTable = new DataTable();
                    adapter.Fill(eventsTable);
                    datagrid.DataSource = eventsTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
                finally { cnx.Close(); }

            }

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void AddBTN_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnx = Program.Getconnection();
            cnx.Close();

            String name = EventNameTXT.Text;
            int stadium = StadiumCombo.SelectedIndex + 1;
            DateTime date = DatePick.Value;
            string formattedDateTime = String.Format("{0:yyyy-MM-dd HH:mm:ss}", date);
            int sport = SportCombo.SelectedIndex+1;
          
            String searchQuery = "select * from evenement where nom_event ='" + name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(searchQuery, cnx);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            using (cnx) {
                
                try
                {
                    cnx.Open();
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("There's already an event with this name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("INSERT INTO evenement(sportID,nom_event,stadiumID,event_DATE)values('" + sport + "','" + name + "','"+stadium + "','" + formattedDateTime + "')", cnx);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Event Added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formLoad();
                    }
                    cnx.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                  
                }
            }
            
              
        }
    }
}
