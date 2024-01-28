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
    public partial class AdminPanel : Form
    {
        AdminPanelHome APH = new AdminPanelHome();
        AdminEVENT AE = new AdminEVENT();
        AdminUSERcs AU  = new AdminUSERcs();
    
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Title.Text = "Events Management";
            AE.TopLevel = false;
            AE.Parent = this;
            mainPanel.Controls.Add(AE);
            AE.Dock = DockStyle.Fill;
            AE.Show();
        }

        private void eventmngmtBTN_Click(object sender, EventArgs e)
        {
            Title.Text = "Events Management";
            AE.TopLevel = false;
            AE.Parent = this;
            mainPanel.Controls.Add(AE);
            AE.Dock = DockStyle.Fill;
            AE.Show();
            APH.Hide();
            AU.Hide();
        }

        private void usrmngmtBTN_Click(object sender, EventArgs e)
        {
            Title.Text = "Users Management";
            AU.TopLevel = false;
            AU.Parent = this;
            mainPanel.Controls.Add(AU);
            AU.Dock = DockStyle.Fill;
            AU.Show();
            APH.Hide();
            AE.Hide();
        }
    }
}
