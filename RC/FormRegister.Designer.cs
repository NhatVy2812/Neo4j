namespace RC
{
    partial class FormRegister
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
            label1 = new Label();
            User = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnDangki = new Button();
            btnvedangnhap = new Button();
            pictureBox1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            rNu = new RadioButton();
            rNam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label1.Location = new Point(506, 235);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 13;
            label1.Text = "Mật khẩu";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            User.Location = new Point(506, 130);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(69, 32);
            User.TabIndex = 12;
            User.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(506, 275);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(377, 50);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(506, 170);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(377, 50);
            txtEmail.TabIndex = 2;
            // 
            // btnDangki
            // 
            btnDangki.BackColor = Color.Silver;
            btnDangki.FlatAppearance.BorderSize = 0;
            btnDangki.FlatStyle = FlatStyle.Flat;
            btnDangki.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangki.Location = new Point(506, 513);
            btnDangki.Margin = new Padding(4, 5, 4, 5);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(184, 67);
            btnDangki.TabIndex = 7;
            btnDangki.Text = "Sign In";
            btnDangki.UseVisualStyleBackColor = false;
            btnDangki.Click += btnDangki_Click;
            // 
            // btnvedangnhap
            // 
            btnvedangnhap.BackColor = Color.Silver;
            btnvedangnhap.FlatAppearance.BorderSize = 0;
            btnvedangnhap.FlatStyle = FlatStyle.Flat;
            btnvedangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnvedangnhap.Location = new Point(727, 513);
            btnvedangnhap.Margin = new Padding(4, 5, 4, 5);
            btnvedangnhap.Name = "btnvedangnhap";
            btnvedangnhap.Size = new Size(184, 67);
            btnvedangnhap.TabIndex = 8;
            btnvedangnhap.Text = "Login";
            btnvedangnhap.UseVisualStyleBackColor = false;
            btnvedangnhap.Click += btnvedangnhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 635);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Location = new Point(506, 380);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(377, 50);
            txtConfirmPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label2.Location = new Point(506, 340);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 15;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rNu);
            panel1.Controls.Add(rNam);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnvedangnhap);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(btnDangki);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(User);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 635);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label4.Location = new Point(515, 456);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 20;
            label4.Text = "Giới tính";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(506, 65);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(377, 50);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label3.Location = new Point(506, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 19;
            label3.Text = "Họ Tên";
            // 
            // rNu
            // 
            rNu.AutoSize = true;
            rNu.Font = new Font("Segoe UI Light", 12F);
            rNu.Location = new Point(772, 454);
            rNu.Margin = new Padding(4, 5, 4, 5);
            rNu.Name = "rNu";
            rNu.Size = new Size(69, 36);
            rNu.TabIndex = 6;
            rNu.TabStop = true;
            rNu.Text = "Nữ";
            rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            rNam.AutoSize = true;
            rNam.Font = new Font("Segoe UI Light", 12F);
            rNam.Location = new Point(641, 454);
            rNam.Margin = new Padding(4, 5, 4, 5);
            rNam.Name = "rNam";
            rNam.Size = new Size(88, 36);
            rNam.TabIndex = 5;
            rNam.TabStop = true;
            rNam.Text = "Nam";
            rNam.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 675);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label User;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnDangki;
        private Button btnvedangnhap;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPassword;
        private Label label2;
        private Panel panel1;
        private RadioButton rNu;
        private RadioButton rNam;
        private TextBox txtName;
        private Label label3;
        private Label label4;
    }
}