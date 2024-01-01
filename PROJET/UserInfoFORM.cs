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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET
{
    public partial class UserInfoFORM : Form
    {
        SqlConnection cnx = Program.Getconnection();
         string user;

        
        
        public UserInfoFORM()
        {
            InitializeComponent();
            
        }
        public void SetUsername(string username)
        {
            user = username;
        }
        public void GetUserInfo(string user)
        {
            cnx.Open();
             try
            {

                string query = $"SELECT * FROM client WHERE username = @username";
                SqlCommand command = new SqlCommand(query,cnx);
                command.Parameters.AddWithValue("@username", user);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Read the user information
                    while (reader.Read())
                    {
                       string First_name = reader.GetString("PRENOM");
                        firstnameTXT.Text = First_name;
                       string Last_name = reader.GetString("NOM");
                        lastnameTXT.Text = Last_name;
                       string adress = reader.GetString("ADRESS");
                        adressTXT.Text = adress;
                       string username = reader.GetString("username");
                        usernameTXT.Text = username;
                       string email = reader.GetString("Email");
                        emailTXT.Text = email;
                        firstLABEL.Text = First_name;
                        lastLABEL.Text = Last_name;
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnx.Close();
        }

        private void UserInfoFORM_Load(object sender, EventArgs e)
        {
            GetUserInfo(user);
        }
    }
}
