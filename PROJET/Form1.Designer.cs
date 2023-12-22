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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            pwdTXT = new TextBox();
            textBox1 = new TextBox();
            materialButton1 = new MaterialSkin2DotNet.Controls.MaterialButton();
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
            pictureBox1.Location = new Point(326, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pwdTXT);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(forgetpwdBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 495);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Window;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(118, 355);
            label6.Name = "label6";
            label6.Size = new Size(100, 13);
            label6.TabIndex = 12;
            label6.Text = "Create an account";
            label6.Click += label6_Click;
            // 
            // pwdTXT
            // 
            pwdTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwdTXT.Location = new Point(38, 219);
            pwdTXT.Name = "pwdTXT";
            pwdTXT.Size = new Size(272, 33);
            pwdTXT.TabIndex = 11;
            pwdTXT.TextChanged += pwdTXT_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 33);
            textBox1.TabIndex = 10;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(113, 301);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(105, 36);
            materialButton1.TabIndex = 9;
            materialButton1.Text = "Connexion";
            materialButton1.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // forgetpwdBtn
            // 
            forgetpwdBtn.AutoSize = true;
            forgetpwdBtn.BackColor = SystemColors.Window;
            forgetpwdBtn.Cursor = Cursors.Hand;
            forgetpwdBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgetpwdBtn.ForeColor = Color.LimeGreen;
            forgetpwdBtn.Location = new Point(208, 272);
            forgetpwdBtn.Name = "forgetpwdBtn";
            forgetpwdBtn.Size = new Size(102, 13);
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
            label5.Location = new Point(38, 195);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(38, 134);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumPurple;
            label3.Location = new Point(113, 40);
            label3.Name = "label3";
            label3.Size = new Size(120, 50);
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
            closeBtn.Location = new Point(745, -2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(49, 43);
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
            label1.Location = new Point(336, 37);
            label1.Name = "label1";
            label1.Size = new Size(342, 47);
            label1.TabIndex = 3;
            label1.Text = "Explore events, buy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(665, 38);
            label2.Name = "label2";
            label2.Size = new Size(129, 47);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 393);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
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
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton1;
        private TextBox pwdTXT;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label label6;
    }
}
