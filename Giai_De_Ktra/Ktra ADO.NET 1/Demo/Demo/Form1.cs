using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
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
            //Khi khỏi đọng form thì nó sẽ thực hiện
            DataTable tableProduct = new DataTable();
            tableProduct = data.GetAllProduct(); //đã có bảng dữ liệu product
            dgv.DataSource = tableProduct;
            ////XOgn dgv

            ///Dến cbo
            DataTable tableCategory = new DataTable();
            tableCategory = data.GetAllCategory();//đã có bảng dữ liệu category
            cboTenHang.DataSource = tableCategory; //Gán source data cho cbo
            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";

            ///
            txtMaSP.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string soLuong = txtSoLuong.Text.Trim();
                string maHang = cboTenHang.SelectedValue.ToString();
                if (String.IsNullOrWhiteSpace(maSP)) throw new Exception("Bạn chưa nhập mã sản phẩm");
                if (String.IsNullOrWhiteSpace(tenSP)) throw new Exception("Bạn chưa nhập tên sản phẩm");
                if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");
                
                if(!int.TryParse(maSP, out int number))
                {
                    throw new Exception("Mã sản phẩm phải là số nguyên");
                }

                foreach (char c in soLuong)
                {
                    if (Char.IsLetter(c)) throw new Exception("Số lượng sản phẩm phải là số nguyên");
                }

                data.InsertProduct(int.Parse(maSP), tenSP, int.Parse(soLuong), int.Parse(maHang));

                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("insert duplicate key"))
                {
                    MessageBox.Show("Mã sản phẩm không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string soLuong = txtSoLuong.Text.Trim();
                string maHang = cboTenHang.SelectedValue.ToString();
                if (String.IsNullOrWhiteSpace(maSP)) throw new Exception("Bạn chưa nhập mã sản phẩm");
                if (String.IsNullOrWhiteSpace(tenSP)) throw new Exception("Bạn chưa nhập tên sản phẩm");
                if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");

                if (!int.TryParse(maSP, out int number))
                {
                    throw new Exception("Mã sản phẩm phải là số nguyên");
                }

                foreach (char c in soLuong)
                {
                    if (Char.IsLetter(c)) throw new Exception("Số lượng sản phẩm phải là số nguyên");
                }

                data.EditProduct(int.Parse(maSP), tenSP, int.Parse(soLuong), int.Parse(maHang));

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                if (String.IsNullOrWhiteSpace(maSP)) throw new Exception("Bạn chưa nhập mã sản phẩm");

                if (!int.TryParse(maSP, out int number))
                {
                    throw new Exception("Mã sản phẩm phải là số nguyên");
                }

                data.DeleteProductById(int.Parse(maSP));

                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();

            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit this program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSP.Text = dgv.Rows[row].Cells[0].Value.ToString();
                txtTenSP.Text = dgv.Rows[row].Cells[1].Value.ToString();
                txtSoLuong.Text = dgv.Rows[row].Cells[2].Value.ToString();

                int maHang = int.Parse(dgv.Rows[row].Cells[3].Value.ToString());
                cboTenHang.Text = data.FindTenHangByMaHang(maHang);
            }
        }
    }
}
