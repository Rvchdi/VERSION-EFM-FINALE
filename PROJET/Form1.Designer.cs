namespace PROJET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            pwdTXT = new TextBox();
            usernameTXT = new TextBox();
            forgetpwdBtn = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            closeBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(605, -4);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1001, 983);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pwdTXT);
            panel1.Controls.Add(usernameTXT);
            panel1.Controls.Add(forgetpwdBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-6, -4);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 1056);
            panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(128, 128, 255);
            guna2Button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(122, 610);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(360, 90);
            guna2Button1.TabIndex = 13;
            guna2Button1.Text = "Connection";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Window;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(190, 713);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 30);
            label6.TabIndex = 12;
            label6.Text = "Create an account";
            label6.Click += label6_Click;
            // 
            // pwdTXT
            // 
            pwdTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwdTXT.Location = new Point(71, 467);
            pwdTXT.Margin = new Padding(6);
            pwdTXT.Name = "pwdTXT";
            pwdTXT.Size = new Size(502, 58);
            pwdTXT.TabIndex = 11;
            pwdTXT.TextChanged += pwdTXT_TextChanged_1;
            // 
            // usernameTXT
            // 
            usernameTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTXT.Location = new Point(71, 337);
            usernameTXT.Margin = new Padding(6);
            usernameTXT.Name = "usernameTXT";
            usernameTXT.Size = new Size(502, 58);
            usernameTXT.TabIndex = 10;
            // 
            // forgetpwdBtn
            // 
            forgetpwdBtn.AutoSize = true;
            forgetpwdBtn.BackColor = SystemColors.Window;
            forgetpwdBtn.Cursor = Cursors.Hand;
            forgetpwdBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgetpwdBtn.ForeColor = Color.LimeGreen;
            forgetpwdBtn.Location = new Point(370, 531);
            forgetpwdBtn.Margin = new Padding(6, 0, 6, 0);
            forgetpwdBtn.Name = "forgetpwdBtn";
            forgetpwdBtn.Size = new Size(203, 30);
            forgetpwdBtn.TabIndex = 4;
            forgetpwdBtn.Text = "Forget password ?";
            forgetpwdBtn.Click += forgetpwdBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(71, 416);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 45);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(71, 286);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumPurple;
            label3.Location = new Point(210, 85);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 99);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ButtonHighlight;
            closeBtn.BackgroundImageLayout = ImageLayout.None;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.MediumSeaGreen;
            closeBtn.Location = new Point(1515, -4);
            closeBtn.Margin = new Padding(6);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(91, 92);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(624, 79);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(681, 93);
            label1.TabIndex = 3;
            label1.Text = "Explore events, buy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(1282, 79);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 93);
            label2.TabIndex = 0;
            label2.Text = "tickets";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 838);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button closeBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label forgetpwdBtn;
        private Label label5;
        private TextBox pwdTXT;
        private TextBox usernameTXT;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
