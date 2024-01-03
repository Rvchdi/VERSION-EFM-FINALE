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
    public partial class AdminUSERcs : Form
    {
        private string user = "";
        SqlConnection cnx = Program.Getconnection();
        DataSet ds;
        SqlDataAdapter adapter;
        public AdminUSERcs()
        {
            InitializeComponent();

        }

        private void AdminUSERcs_Load(object sender, EventArgs e)
        {
            
            ds = new DataSet();
            cnx = Program.Getconnection();
            using (cnx)
            {
                string query = "SELECT * FROM client";
                DataTable users = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, cnx))
                {
                    adapter.Fill(users);
                }
                datagrid.DataSource = users;


                cboRole.Items.Add("user");
                cboRole.Items.Add("admin");
                cboRole.SelectedIndex = 0;
            }
        }
        public void setUser(string x) {
            user = x;
        }
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUsername.Text = datagrid.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtEmail.Text = datagrid.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtAddress.Text = datagrid.Rows[e.RowIndex].Cells["Adress"].Value.ToString();
                cboRole.SelectedItem = datagrid.Rows[e.RowIndex].Cells["Role"].Value;
                user = datagrid.Rows[e.RowIndex].Cells["clientID"].Value.ToString();
                setUser(user);


            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            cnx = Program.Getconnection();
            string selected_role = cboRole.Text;
            string query = "UPDATE client set role = '" + selected_role + "' where clientID =" + user + ";";
            MessageBox.Show($"{selected_role}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
             if (user != "") {
                using (cnx) { 
                    SqlCommand command = new SqlCommand(query, cnx);
                    cnx.Open();
                    command.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("Role updated successfully","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
           


        }
    }
}
