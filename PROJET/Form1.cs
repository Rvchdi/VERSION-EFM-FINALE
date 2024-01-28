

using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace PROJET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void forgetpwdBtn_Click(object sender, EventArgs e)
        {


        }

        private void usernameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdTXT_TextChanged(object sender, EventArgs e)
        {


        }

        private void pwdTXT_TextChanged_1(object sender, EventArgs e)
        {

            pwdTXT.PasswordChar = '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CreateAccount crt = new CreateAccount();
            crt.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernameTXT.Text;
            string password = pwdTXT.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection cnx = Program.Getconnection())
                {
                    cnx.Open();

                    string query = $"SELECT role,clientID FROM client WHERE USERNAME = '"+username+"' AND PWD = '"+password+"'";
                    using (SqlCommand command = new SqlCommand(query, cnx))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader.GetString("ROLE");
                                int idint = reader.GetInt32("clientID");
                                Session.user = Convert.ToString(idint);
                                if (role == "admin")
                                {
                                    AdminPanel main = new AdminPanel();
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    UserForm userform = new UserForm();
                                    userform.SetUsername(username);
                                    userform.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
