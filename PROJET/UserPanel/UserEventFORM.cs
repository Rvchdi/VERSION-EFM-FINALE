using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROJET
{
    public partial class UserEventFORM : Form
    {        
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        BindingManagerBase bindingManager;
        SqlConnection cnx = Program.Getconnection();
        DataTable dt;

        public UserEventFORM()
        {
            InitializeComponent();
        }

        private void DataLoad(string query)
        {

            dataSet = new DataSet();

            cnx = Program.Getconnection();
            cnx.Open();

            adapter = new SqlDataAdapter(query, cnx);
            adapter.Fill(dataSet, "events");
            builder = new SqlCommandBuilder(adapter);
            dt = dataSet.Tables["events"];
            bindingManager = BindingContext[dt];
            DataView dataView = new DataView(dt);
            DataGrid.DataSource = dataView;
            cnx.Close();
        }

        private void UserEventFORM_Load(object sender, EventArgs e)
        {
            
            
            string query = "SELECT eventID,nom_event, nom_sport, nom_stade, event_DATE FROM evenement E inner join sport S on E.sportID = S.sportID inner join stade ST on E.stadiumID=ST.stadiumID";
            DataLoad(query);
            cnx = Program.Getconnection();
            cnx.Open();

            string filter = "SELECT nom_sport FROM sport";
            SqlCommand command = new SqlCommand(filter, cnx);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string sportName = reader["nom_sport"].ToString();
                    sportCBO.Items.Add(sportName);
                }
            }

            cnx.Close();
            if (DataGrid.Columns.Contains("eventID"))
            {
                DataGrid.Columns["eventID"].Visible = false;
            }
        }

        private void sportCBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sport = sportCBO.Text.ToString();
            ((DataView)DataGrid.DataSource).RowFilter = $"nom_sport = '{sport}'";
            
           
        }

        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTXT.Text.Trim();
            ((DataView)DataGrid.DataSource).RowFilter = $"nom_event LIKE '%{searchText}%' OR nom_sport LIKE '%{searchText}%' OR nom_stade LIKE '%{searchText}%'";
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
    {
                DataGridViewRow selectedRow = DataGrid.Rows[e.RowIndex];  
                int eventID = Convert.ToInt32(selectedRow.Cells["eventID"].Value);
                BuyTicketForm buyTicketForm = new BuyTicketForm(eventID);
                buyTicketForm.Show();
            }
        }
    }
}
