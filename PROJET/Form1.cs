

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
            MainApp Main = new MainApp();
            Main.Show();

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
    }
}
