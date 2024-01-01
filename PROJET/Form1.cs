

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
            Application.Exit();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connected successfully", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string username = usernameTXT.Text;
            string password = pwdTXT.Text;
            SqlConnection cnx = Program.Getconnection();
            String query = "SELECT USERNAME,PWD,ROLE from client WHERE USERNAME='" + username + "'AND PWD='" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnx);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            

            if (username == "" || password == "")
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dtable.Rows.Count > 0)
                {
                    cnx.Open();
                    string rolequery = $"SELECT ROLE FROM client WHERE USERNAME = @username";
                    SqlCommand command = new SqlCommand(rolequery, cnx);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        string role = reader.GetString("ROLE");
                        if (role == "admin")
                        {
                            AdminPanel main = new AdminPanel();
                            main.Show();
                            this.Hide();
                            cnx.Close();
                        }
                        else
                        {
                            UserForm userform = new UserForm();
                            userform.SetUsername(username);
                            userform.Show();
                            this.Hide();
                            cnx.Close();

                        }
                    }
                    else {
                        MessageBox.Show("No data retrieved");
                    }
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username = "";
                    password = "";
                }
            }
        }
    }
}
