using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC
{
    public partial class Formcheckout : Form
    {
        private Neo4jConnection _connection;
        private string productName;
        private string userEmail;
        private int quantity;
        private decimal price;

        public Formcheckout(Neo4jConnection connection,string email, string name, int quantity, decimal price)
        {
            InitializeComponent();
            _connection = connection;
            this.productName = name;
            this.userEmail = email;
            this.quantity = quantity;
            this.price = price;

            // Hiển thị thông tin trên form
            lblEmail.Text = userEmail;
            lblProductName.Text = productName;
            lblQuantity.Text = quantity.ToString();
            lblPrice.Text = price.ToString("C", new CultureInfo("vi-VN")); // Định dạng giá với VND
            lblTotal.Text = (quantity * price).ToString("C", new CultureInfo("vi-VN")); // Tính thành tiền với VND
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Gọi phương thức để lưu thông tin khi thanh toán
                await _connection.HandleBuyClickAsync(productName, userEmail, quantity);
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form thanh toán
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }

        }
    }
}
