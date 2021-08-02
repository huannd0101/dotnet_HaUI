using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo3Layer
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
            DataTable table = new DataTable();
            table = data.ShowAllProducts();
            dgv.DataSource = table;

            //category
            DataTable table2 = new DataTable();
            table2 = data.ShowAllCategory();
            comboBox1.DataSource = table2;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtMaSP.Text;
                string moTa = txtMoTa.Text;
                string gia = txtGia.Text;
                string soLuong = txtSoLuong.Text;
                if (String.IsNullOrWhiteSpace(id)) throw new Exception("Bạn chưa nhập mã sản phẩm");
                if (String.IsNullOrWhiteSpace(moTa)) throw new Exception("Bạn chưa nhập mô tả sản phẩm");
                if (String.IsNullOrWhiteSpace(gia)) throw new Exception("Bạn chưa nhập giá sản phẩm");
                if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");
                foreach(char c in gia)
                {
                    if(Char.IsLetter(c)) throw new Exception("Bạn nhập sai format giá sản phẩm");
                }
                foreach(char c in soLuong)
                {
                    if (Char.IsLetter(c)) throw new Exception("Bạn nhập sai format số lượng sản phẩm");
                    if (c == ',') throw new Exception("Số lượng sản phẩm phải là một số nguyên");
                }
                string categoryId = comboBox1.SelectedValue.ToString();
                data.InsertProduct(id, moTa, double.Parse(gia), int.Parse(soLuong), categoryId);
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtMaSP.Text;
            string moTa = txtMoTa.Text;
            string gia = txtGia.Text;
            string soLuong = txtSoLuong.Text;
            if (String.IsNullOrWhiteSpace(id)) throw new Exception("Bạn chưa nhập mã sản phẩm");
            if (String.IsNullOrWhiteSpace(moTa)) throw new Exception("Bạn chưa nhập mô tả sản phẩm");
            if (String.IsNullOrWhiteSpace(gia)) throw new Exception("Bạn chưa nhập giá sản phẩm");
            if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");
            foreach (char c in gia)
            {
                if (Char.IsLetter(c)) throw new Exception("Bạn nhập sai format giá sản phẩm");
            }
            foreach (char c in soLuong)
            {
                if (Char.IsLetter(c)) throw new Exception("Bạn nhập sai format số lượng sản phẩm");
                if (c == ',') throw new Exception("Số lượng sản phẩm phải là một số nguyên");
            }
            string categoryId = comboBox1.SelectedValue.ToString();

            data.EditProduct(id, moTa, double.Parse(gia), int.Parse(soLuong), categoryId);

            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaSP.Text;
            if (String.IsNullOrWhiteSpace(id)) throw new Exception("Bạn chưa nhập mã sản phẩm");

            data.DeleteProductById(id);

            Form1_Load(sender, e);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSP.Text = dgv.Rows[row].Cells[0].Value.ToString();
                txtMoTa.Text = dgv.Rows[row].Cells[1].Value.ToString();
                txtGia.Text = dgv.Rows[row].Cells[2].Value.ToString();
                txtSoLuong.Text = dgv.Rows[row].Cells[3].Value.ToString();
                string categoryID = dgv.Rows[row].Cells[4].Value.ToString();

                comboBox1.Text = data.GetCategoryNameByID(categoryID);
            }
        }
    }
}
