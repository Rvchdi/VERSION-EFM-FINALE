namespace PROJET
{
    partial class UserEventFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            sportCBO = new Guna.UI2.WinForms.Guna2ComboBox();
            searchTXT = new Guna.UI2.WinForms.Guna2TextBox();
            homePanel = new Panel();
            DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2GroupBox1.SuspendLayout();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(guna2HtmlLabel2);
            guna2GroupBox1.Controls.Add(guna2HtmlLabel1);
            guna2GroupBox1.Controls.Add(sportCBO);
            guna2GroupBox1.Controls.Add(searchTXT);
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(23, 107, 135);
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.White;
            guna2GroupBox1.Location = new Point(22, 26);
            guna2GroupBox1.Margin = new Padding(6);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(1852, 247);
            guna2GroupBox1.TabIndex = 0;
            guna2GroupBox1.Text = "Search Events";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(690, 79);
            guna2HtmlLabel2.Margin = new Padding(6);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(200, 47);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "Filter by sport";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(50, 79);
            guna2HtmlLabel1.Margin = new Padding(6);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(228, 47);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Search by name";
            // 
            // sportCBO
            // 
            sportCBO.BackColor = Color.Transparent;
            sportCBO.CustomizableEdges = customizableEdges1;
            sportCBO.DrawMode = DrawMode.OwnerDrawFixed;
            sportCBO.DropDownStyle = ComboBoxStyle.DropDownList;
            sportCBO.FocusedColor = Color.FromArgb(94, 148, 255);
            sportCBO.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sportCBO.Font = new Font("Segoe UI", 10F);
            sportCBO.ForeColor = Color.FromArgb(68, 88, 112);
            sportCBO.ItemHeight = 70;
            sportCBO.Location = new Point(690, 129);
            sportCBO.Margin = new Padding(6);
            sportCBO.Name = "sportCBO";
            sportCBO.ShadowDecoration.CustomizableEdges = customizableEdges2;
            sportCBO.Size = new Size(401, 76);
            sportCBO.TabIndex = 2;
            sportCBO.SelectedIndexChanged += sportCBO_SelectedIndexChanged;
            // 
            // searchTXT
            // 
            searchTXT.CustomizableEdges = customizableEdges3;
            searchTXT.DefaultText = "";
            searchTXT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTXT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTXT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTXT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTXT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTXT.Font = new Font("Segoe UI", 9F);
            searchTXT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTXT.Location = new Point(50, 128);
            searchTXT.Margin = new Padding(11, 13, 11, 13);
            searchTXT.Name = "searchTXT";
            searchTXT.PasswordChar = '\0';
            searchTXT.PlaceholderText = "";
            searchTXT.SelectedText = "";
            searchTXT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchTXT.Size = new Size(552, 77);
            searchTXT.TabIndex = 0;
            searchTXT.TextChanged += searchTXT_TextChanged;
            // 
            // homePanel
            // 
            homePanel.AutoScroll = true;
            homePanel.AutoScrollMargin = new Size(10, 10);
            homePanel.AutoScrollMinSize = new Size(10, 10);
            homePanel.AutoSize = true;
            homePanel.BorderStyle = BorderStyle.FixedSingle;
            homePanel.Controls.Add(DataGrid);
            homePanel.Location = new Point(22, 301);
            homePanel.Margin = new Padding(6);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1809, 919);
            homePanel.TabIndex = 1;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.ColumnHeadersHeight = 80;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.GridColor = Color.FromArgb(231, 229, 255);
            DataGrid.Location = new Point(0, 0);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidth = 82;
            DataGrid.Size = new Size(1807, 917);
            DataGrid.TabIndex = 0;
            DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGrid.ThemeStyle.BackColor = Color.White;
            DataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGrid.ThemeStyle.HeaderStyle.Height = 80;
            DataGrid.ThemeStyle.ReadOnly = true;
            DataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGrid.ThemeStyle.RowsStyle.Height = 41;
            DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGrid.CellContentClick += DataGrid_CellContentClick;
            // 
            // UserEventFORM
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1896, 1250);
            ControlBox = false;
            Controls.Add(homePanel);
            Controls.Add(guna2GroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "UserEventFORM";
            Text = "UserEventFORM";
            Load += UserEventFORM_Load;
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox sportCBO;
        private Guna.UI2.WinForms.Guna2TextBox searchTXT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel homePanel;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
    }
}