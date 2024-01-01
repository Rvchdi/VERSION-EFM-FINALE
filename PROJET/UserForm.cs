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
            UserInfoFORM userInfo = new UserInfoFORM();
            userInfo.TopLevel = false;
            userInfo.Parent = this;
            mainPanel.Controls.Add(userInfo);
            userInfo.SetUsername(user);
            userInfo.Dock = DockStyle.Fill;
            userInfo.Show();
        }
    }
}
