using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace PROJET
{
    public partial class CreateAccount : Form
    {
        MySqlConnection cnx = Program.Getconnection();
        string connectionString = "Server=localhost;Database=efm;Uid=user;Pwd='';";

        public CreateAccount()
        {
            InitializeComponent();
            pctrbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pwdTXT_TextChanged(object sender, EventArgs e)
        {
            pwdTXT.PasswordChar = '*';
            pwdconfirmTXT.PasswordChar = '*';
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                MessageBox.Show("Connected successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmBTN_Click(object sender, EventArgs e)
        {
            List<string> Details = new List<string>();
            MySqlConnection cnx = Program.Getconnection();  
            
            String firstname = firstnameTXT.Text;
            String lastname = lastnameTXT.Text;
            String adress = adressTXT.Text;
            String gender = genderCOMBO.SelectedItem?.ToString()??"Non specified";
            String email = emailTXT.Text;
            String username = usernameTXT.Text;
            String password = pwdTXT.Text;
            String passwordConfirm = pwdconfirmTXT.Text;
            if (password != passwordConfirm) {
                MessageBox.Show("Passwords are not identical", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (firstname == "" || lastname == "" || adress == "" || username == "" || password == "" || passwordConfirm == "" || email == "") {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            while (true) {
                cnx.Open();
                using (cnx)
                {
                    string sqlRequest = "INSERT INTO client (NOM, PRENOM,ADRESS,gender,EMAIL,USERNAME,PWD,ROLE) VALUES (@Value1, @Value2,@Value3,@Value4,@Value5,@Value6,@Value7,@Value8)";
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(sqlRequest, cnx))
                        {
                            command.Parameters.AddWithValue("@Value1", firstname);
                            command.Parameters.AddWithValue("@Value2", lastname);
                            command.Parameters.AddWithValue("@Value3", adress);
                            command.Parameters.AddWithValue("@Value4", gender);
                            command.Parameters.AddWithValue("@Value5", email);
                            command.Parameters.AddWithValue("@Value6", username);
                            command.Parameters.AddWithValue("@Value7", password);
                            command.Parameters.AddWithValue("@Value8", "user");

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Handle successful insertion (e.g., display a message)
                                if (MessageBox.Show("Account created successfully", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    this.Close();
                                }


                            }
                            else {
                                if (MessageBox.Show($"Error", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) {
                                    adressTXT.Clear();
                                    firstnameTXT.Clear();
                                    lastnameTXT.Clear();
                                    genderCOMBO.ResetText();
                                    pwdconfirmTXT.Clear();
                                    pwdTXT.Clear();
                                    usernameTXT.Clear();
                                    emailTXT.Clear();
                                };
                            }
                        }
                     }
                    catch(MySqlException ex ) {
                        /*MessageBox.Show($"{ex}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                        break;
                    }
                                    
                    }
                   
                }
            }





        }
    }

