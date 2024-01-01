using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;



namespace PROJET
{
    public partial class MainApp : Form
    {
        private string user;
        
        public MainApp()
        {
            InitializeComponent();
                        
        }
        public void SetUsername(string username)
        {
            user = username; 
        }

        UserInfoFORM userInfo = new UserInfoFORM();
        EventForm eventForm = new EventForm();
        MyTicketsFORMcs ticketForm = new MyTicketsFORMcs();

        private void MainApp_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            userInfo.TopLevel = false;
            userInfo.Parent = this;
            userInfo.SetUsername(user);
            mainPanel.Controls.Add(userInfo);
            userInfo.Dock = DockStyle.Fill;
            userInfo.Show();
            eventForm.Hide();
            ticketForm.Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            eventForm.TopLevel = false;
            eventForm.Parent = this;
            mainPanel.Controls.Add(eventForm);
            eventForm.Dock = DockStyle.Fill;
            eventForm.Show();
            userInfo.Hide();
            ticketForm.Hide();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ticketForm.TopLevel = false;
            ticketForm.Parent = this;
            mainPanel.Controls.Add(ticketForm);
            ticketForm.Dock = DockStyle.Fill;
            ticketForm.Show();
            userInfo.Hide();
            eventForm.Hide();

        }
    }
}
