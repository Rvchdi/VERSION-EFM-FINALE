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
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            APH.TopLevel = false;
            APH.Parent = this;
            mainPanel.Controls.Add(APH);
            APH.Dock = DockStyle.Fill;
            APH.Show();
        }

        private void eventmngmtBTN_Click(object sender, EventArgs e)
        {
            AE.TopLevel = false;
            AE.Parent = this;
            mainPanel.Controls.Add(AE);
            AE.Dock = DockStyle.Fill;
            AE.Show();
            APH.Hide();
        }
    }
}
