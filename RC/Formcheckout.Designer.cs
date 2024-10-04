namespace RC
{
    partial class Formcheckout
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblEmail = new Label();
            lblProductName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            Username = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Light", 11F);
            lblEmail.Location = new Point(364, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 30);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Light", 11F);
            lblProductName.Location = new Point(364, 152);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(68, 30);
            lblProductName.TabIndex = 10;
            lblProductName.Text = "label2";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Light", 11F);
            lblQuantity.Location = new Point(364, 212);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 30);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "label3";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Light", 11F);
            lblPrice.Location = new Point(364, 268);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 30);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "label4";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Light", 11F);
            lblTotal.Location = new Point(364, 325);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 30);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "label5";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Light", 11F);
            Username.Location = new Point(166, 92);
            Username.Name = "Username";
            Username.Size = new Size(111, 30);
            Username.TabIndex = 14;
            Username.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 11F);
            label2.Location = new Point(166, 152);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 15;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 11F);
            label3.Location = new Point(166, 212);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 16;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 11F);
            label4.Location = new Point(166, 268);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 17;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 11F);
            label5.Location = new Point(166, 325);
            label5.Name = "label5";
            label5.Size = new Size(61, 30);
            label5.TabIndex = 18;
            label5.Text = "Total:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BorderRadius = 20;
            btnThanhToan.CustomizableEdges = customizableEdges1;
            btnThanhToan.DisabledState.BorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThanhToan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThanhToan.FillColor = Color.Silver;
            btnThanhToan.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.FromArgb(64, 64, 64);
            btnThanhToan.Location = new Point(235, 389);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThanhToan.Size = new Size(194, 68);
            btnThanhToan.TabIndex = 19;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 21);
            label6.Name = "label6";
            label6.Size = new Size(211, 44);
            label6.TabIndex = 20;
            label6.Text = "CHECKOUT";
            // 
            // Formcheckout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 479);
            Controls.Add(label6);
            Controls.Add(btnThanhToan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblProductName);
            Controls.Add(lblEmail);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Formcheckout";
            Text = "Formcheckout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEmail;
        private Label lblProductName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblTotal;
        private Label Username;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Label label6;
    }
}