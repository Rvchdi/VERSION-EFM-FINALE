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
            datagrid.ReadOnly = true;

        }
        private void AdminUSERcs_Load(object sender, EventArgs e)
        {
            cboRole.Items.Add("user");
            cboRole.Items.Add("admin");
            dataLoad();
        }
        public void dataLoad() {
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
                cboRole.SelectedIndex = 0;
            }
        }
        public void setUser(string x)
        {
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
            string query = "UPDATE client SET ROLE = @Role, USERNAME = @Username, ADRESS = @Address, EMAIL = @Email WHERE clientID = @ID";        
            if (user != "" )
            {
                using (cnx)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@Role", selected_role);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@ID", user);

                        cnx.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            dataLoad();
                            MessageBox.Show("Informations updated successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { 
                            MessageBox.Show($"There was an error while updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (SqlException ex) { 
                            MessageBox.Show($"There was an error while updating. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    cnx.Close();
                    
                }
            }



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewUserTicket VUT;
            VUT = new ViewUserTicket(Convert.ToInt32(user));
            VUT.Show();

        }

        private void datagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
