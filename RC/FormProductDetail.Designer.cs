namespace RC
{
    partial class FormProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductDetail));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            motaSP = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PN3 = new Panel();
            btnBuy = new Button();
            soLuong = new Label();
            btnInc = new Button();
            btnDes = new Button();
            giaSP = new Label();
            nameSP = new Label();
            anhSP = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anhSP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(motaSP);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PN3);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(soLuong);
            panel1.Controls.Add(btnInc);
            panel1.Controls.Add(btnDes);
            panel1.Controls.Add(giaSP);
            panel1.Controls.Add(nameSP);
            panel1.Controls.Add(anhSP);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 1212);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(746, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 41);
            label4.TabIndex = 14;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(918, 316);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 40);
            label3.TabIndex = 13;
            label3.Text = "VND";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(751, 397);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 41);
            label2.TabIndex = 12;
            label2.Text = "Số lượng:";
            label2.Click += label2_Click;
            // 
            // motaSP
            // 
            motaSP.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point, 0);
            motaSP.Location = new Point(751, 160);
            motaSP.Name = "motaSP";
            motaSP.Size = new Size(441, 158);
            motaSP.TabIndex = 0;
            motaSP.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 572);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 2;
            label1.Text = "Sản phẩm liên quan";
            // 
            // PN3
            // 
            PN3.AutoScroll = true;
            PN3.Location = new Point(88, 635);
            PN3.Margin = new Padding(4, 5, 4, 5);
            PN3.Name = "PN3";
            PN3.Size = new Size(1203, 381);
            PN3.TabIndex = 10;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(760, 477);
            btnBuy.Margin = new Padding(4, 5, 4, 5);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(373, 80);
            btnBuy.TabIndex = 9;
            btnBuy.Text = "Mua ngay";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // soLuong
            // 
            soLuong.AutoSize = true;
            soLuong.Font = new Font("Segoe UI", 12F);
            soLuong.Location = new Point(988, 403);
            soLuong.Margin = new Padding(4, 0, 4, 0);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(27, 32);
            soLuong.TabIndex = 8;
            soLuong.Text = "1";
            // 
            // btnInc
            // 
            btnInc.Font = new Font("Segoe UI", 12F);
            btnInc.Location = new Point(1034, 394);
            btnInc.Margin = new Padding(4, 5, 4, 5);
            btnInc.Name = "btnInc";
            btnInc.Size = new Size(51, 50);
            btnInc.TabIndex = 7;
            btnInc.Text = "+";
            btnInc.UseVisualStyleBackColor = true;
            btnInc.Click += btnInc_Click;
            // 
            // btnDes
            // 
            btnDes.Font = new Font("Segoe UI", 12F);
            btnDes.Location = new Point(918, 394);
            btnDes.Margin = new Padding(4, 5, 4, 5);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(51, 50);
            btnDes.TabIndex = 6;
            btnDes.Text = "-";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // giaSP
            // 
            giaSP.AutoSize = true;
            giaSP.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            giaSP.ForeColor = Color.Brown;
            giaSP.Location = new Point(751, 316);
            giaSP.Margin = new Padding(4, 0, 4, 0);
            giaSP.Name = "giaSP";
            giaSP.Size = new Size(197, 40);
            giaSP.TabIndex = 2;
            giaSP.Text = "Giá sản phẩm";
            // 
            // nameSP
            // 
            nameSP.AutoSize = true;
            nameSP.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameSP.Location = new Point(746, 59);
            nameSP.Margin = new Padding(4, 0, 4, 0);
            nameSP.Name = "nameSP";
            nameSP.Size = new Size(198, 33);
            nameSP.TabIndex = 1;
            nameSP.Text = "Tên sản phẩm";
            // 
            // anhSP
            // 
            anhSP.Location = new Point(129, 30);
            anhSP.Margin = new Padding(4, 5, 4, 5);
            anhSP.Name = "anhSP";
            anhSP.Size = new Size(551, 525);
            anhSP.SizeMode = PictureBoxSizeMode.Zoom;
            anhSP.TabIndex = 0;
            anhSP.TabStop = false;
            // 
            // FormProductDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 1050);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProductDetail";
            FormClosing += FormProductDetail_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)anhSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label giaSP;
        private Label nameSP;
        private PictureBox anhSP;
        private Label soLuong;
        private Button btnInc;
        private Button btnDes;
        private Button btnBuy;
        private Panel PN3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label motaSP;
        private Label label3;
        private Label label4;
    }
}