using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataProcessing data = new DataProcessing();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tableCategory = data.GetAllCategory();
            DataTable tableProduct = data.GetAllProduct();
            dataGridView1.DataSource = tableProduct;

            cbboxChungLoai.DataSource = tableCategory;
            cbboxChungLoai.DisplayMember = "TenChungLoai";
            cbboxChungLoai.ValueMember = "MaChungLoai";

            cbboxDonViTinh.DataSource = tableProduct;
            cbboxDonViTinh.DisplayMember = "DonViTinh";
            cbboxDonViTinh.ValueMember = "DonViTinh";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                int maChungLoai = int.Parse(cbboxChungLoai.SelectedValue.ToString());
                string maMon = txtMaMon.Text.Trim();
                string tenMon = txtTenMon.Text.Trim();
                int dongChai = (checkbox.Checked) ? 1 : 0;
                string donViTinh = cbboxDonViTinh.Text;
                string donGia = txtGia.Text.Trim();
                if (String.IsNullOrWhiteSpace(maMon)) throw new Exception("Bạn chưa nhập mã món");
                if (String.IsNullOrWhiteSpace(tenMon)) throw new Exception("Bạn chưa nhập tên món");
                if (String.IsNullOrWhiteSpace(donGia)) throw new Exception("Bạn chưa nhập đơn giá món");

                data.InsertProduct(int.Parse(maMon), tenMon, dongChai, donViTinh, int.Parse(donGia), maChungLoai);

                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("insert duplicate key"))
                {
                    MessageBox.Show("Mã sản phẩm không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = txtMaMon.Text.Trim();
                if (String.IsNullOrWhiteSpace(maMon)) throw new Exception("Bạn chưa nhập mã món");

                data.DeleteProductById(int.Parse(maMon));

                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit this program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
