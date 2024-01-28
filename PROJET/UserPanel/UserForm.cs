using Microsoft.VisualBasic.ApplicationServices;
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


    public partial class UserForm : Form
    {
        UserInfoFORM userInfo = new UserInfoFORM();
        UserEventFORM userEvent = new UserEventFORM();
        MyTicketsFORMcs MTF = new MyTicketsFORMcs();


        public static string user;
        public UserForm()
        {
            InitializeComponent();
        }

        public void SetUsername(string username)
        {
            user = username;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            userInfo.TopLevel = false;
            userInfo.Parent = this;
            mainPanel.Controls.Add(userInfo);
            userInfo.SetUsername(user);
            userInfo.Dock = DockStyle.Fill;
            userInfo.Show();
        }

        private void eventBTN_Click(object sender, EventArgs e)
        {
            userEvent.TopLevel = false;
            userEvent.Parent = this;
            mainPanel.Controls.Add(userEvent);
            userEvent.Show();
            userInfo.Hide();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            userInfo.TopLevel = false;
            userInfo.Parent = this;
            mainPanel.Controls.Add(userInfo);
            userInfo.Show();
            userEvent.Hide();
            MTF.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MTF.TopLevel = false;
            MTF.Parent = this;
            mainPanel.Controls.Add(MTF);
            MTF.Show();
            userInfo.Hide();
            userEvent.Hide();
            
        }
    }
}
