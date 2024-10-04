namespace RC
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnDangnhap = new Guna.UI2.WinForms.Guna2Button();
            btnDangki = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDangnhap
            // 
            btnDangnhap.BorderRadius = 20;
            btnDangnhap.CustomizableEdges = customizableEdges1;
            btnDangnhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangnhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangnhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangnhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangnhap.FillColor = Color.DarkGray;
            btnDangnhap.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDangnhap.ForeColor = Color.White;
            btnDangnhap.Location = new Point(41, 301);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangnhap.Size = new Size(178, 68);
            btnDangnhap.TabIndex = 0;
            btnDangnhap.Text = "Login";
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnDangki
            // 
            btnDangki.BorderRadius = 20;
            btnDangki.CustomizableEdges = customizableEdges3;
            btnDangki.DisabledState.BorderColor = Color.DarkGray;
            btnDangki.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangki.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangki.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangki.FillColor = Color.DarkGray;
            btnDangki.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDangki.ForeColor = Color.White;
            btnDangki.Location = new Point(246, 301);
            btnDangki.Name = "btnDangki";
            btnDangki.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDangki.Size = new Size(180, 68);
            btnDangki.TabIndex = 1;
            btnDangki.Text = "Sign in";
            btnDangki.Click += btnDangki_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 20;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "123";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(74, 206);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(280, 61);
            txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.BorderRadius = 20;
            txtUser.CustomizableEdges = customizableEdges7;
            txtUser.DefaultText = "name@gmail.com";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI", 9F);
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(74, 79);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PlaceholderText = "";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtUser.Size = new Size(280, 60);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDangnhap);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(btnDangki);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 450);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(74, 156);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(74, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(508, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 450);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(panel1);
            Name = "FormLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDangnhap;
        private Guna.UI2.WinForms.Guna2Button btnDangki;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}