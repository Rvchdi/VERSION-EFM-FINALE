using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        string eventID;

        public AdminEVENT()
        {
            InitializeComponent();
            if (eventID == null)
            {
                modifyBTN.Enabled = false;
                deleteBTN.Enabled = false;
            }
            

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
        private void formLoad()
        {
            cnx = Program.Getconnection();
            using (cnx)
            {
                try
                {
                    cnx.Open();
                    string sql = "SELECT eventID,nom_event as Event_Name,nom_sport as Sport,nom_stade as Stadium,event_Date FROM sport S INNER JOIN  evenement E on S.sportID=E.sportID INNER JOIN  stade ST on st.stadiumID=E.stadiumID";
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
                    string sql = "SELECT * FROM EventView";
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
            int sport = SportCombo.SelectedIndex + 1;

            String searchQuery = "select * from evenement where nom_event ='" + name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(searchQuery, cnx);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            using (cnx)
            {

                try
                {
                    cnx.Open();
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("There's already an event with this name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO evenement(sportID,nom_event,stadiumID,event_DATE)values('" + sport + "','" + name + "','" + stadium + "','" + formattedDateTime + "')", cnx);
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

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eventID = datagrid.Rows[e.RowIndex].Cells["eventID"].Value.ToString();
            EventNameTXT.Text = datagrid.Rows[e.RowIndex].Cells["Event_Name"].Value.ToString();
            SportCombo.SelectedItem = datagrid.Rows[e.RowIndex].Cells["Sport"].Value.ToString();
            StadiumCombo.SelectedItem = datagrid.Rows[e.RowIndex].Cells["stadium"].Value.ToString();

            modifyBTN.Enabled = true;
            deleteBTN.Enabled = true;
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            String name = EventNameTXT.Text;
            int stadium = StadiumCombo.SelectedIndex + 1;
            DateTime date = DatePick.Value;
            string formattedDateTime = String.Format("{0:yyyy-MM-dd HH:mm:ss}", date);
            int sport = SportCombo.SelectedIndex + 1;
            cnx = Program.Getconnection();
            string query = "UPDATE evenement SET nom_event = @eventname, event_DATE = @date, stadiumID = @stadium WHERE eventID = @ID";
            using (cnx)
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand(query, cnx);
                try
                {
                    
                    cmd.Parameters.AddWithValue("@eventname", name);
                    cmd.Parameters.AddWithValue("@date", formattedDateTime);
                    cmd.Parameters.AddWithValue("@stadium", stadium);
                    cmd.Parameters.AddWithValue("@ID", eventID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        formLoad();
                        MessageBox.Show("Informations updated successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"There was an error while updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"There was an error while updating.{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            cnx = Program.Getconnection();
            string query = "DELETE FROM evenement WHERE eventID = @ID";
            using (cnx)
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand(query, cnx);
                try
                {
                    cmd.Parameters.AddWithValue("@ID", eventID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        eventID = null;
                        formLoad();                        
                        MessageBox.Show("Event deleted successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"There was an error while deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"There was an error while updating.{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            cnx = Program.Getconnection();
            try
            {
                using (cnx)
                {
                    cnx.Open();

                    using (SqlCommand cmd = new SqlCommand("DeleteOldEvents", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Database refreshed successfully.");
                    formLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

