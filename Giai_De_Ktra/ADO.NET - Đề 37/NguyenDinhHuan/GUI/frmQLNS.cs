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
using BUS;

namespace GUI
{
    public partial class frmQLNS : Form
    {
        public frmQLNS()
        {
            InitializeComponent();
        }

        BUS_Class bus = new BUS_Class();

        private void frmQLNS_Load(object sender, EventArgs e)
        {
            DataTable table = bus.GetAllNhanSu();
            dgv.DataSource = table;

            cboChucVu.DataSource = table;
            cboChucVu.DisplayMember = "ChucVu";
            cboChucVu.ValueMember = "ChucVu";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row >= 0)
            {
                txtMaNhanVien.Text = dgv.Rows[row].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgv.Rows[row].Cells[1].Value.ToString();
                dtpNamSinh.Value = DateTime.Parse(dgv.Rows[row].Cells[2].Value.ToString());
                if (bool.Parse(dgv.Rows[row].Cells[3].Value.ToString()))
                {
                    chkNu.Checked = true;
                }else
                {
                    chkNu.Checked = false;
                }
                cboChucVu.Text = dgv.Rows[row].Cells[4].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNS = txtMaNhanVien.Text;
                string tenNS = txtTenNhanVien.Text;
                string ngaySinh = dtpNamSinh.Value.ToString("yyyy/MM/dd");
                int nu = (chkNu.Checked) ? 1 : 0;
                string chucVu = cboChucVu.SelectedValue.ToString();
                if (String.IsNullOrWhiteSpace(maNS)) throw new Exception("Mã nhân sự không được để trống");
                if (String.IsNullOrWhiteSpace(tenNS)) throw new Exception("Tên nhân sự không được để trống");

                bus.InsertNS(maNS, tenNS, ngaySinh, nu, chucVu);

                MessageBox.Show("Đã thêm thành công nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLNS_Load(sender, e);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNS = txtMaNhanVien.Text;
                string tenNS = txtTenNhanVien.Text;
                string ngaySinh = dtpNamSinh.Value.ToString("yyyy/MM/dd");
                int nu = (chkNu.Checked) ? 1 : 0;
                string chucVu = cboChucVu.SelectedValue.ToString();
                if (String.IsNullOrWhiteSpace(maNS)) throw new Exception("Mã nhân sự không được để trống");
                if (String.IsNullOrWhiteSpace(tenNS)) throw new Exception("Tên nhân sự không được để trống");

                DataTable table = bus.FindNSById(maNS);
                string val = table.Rows[0].ItemArray[0].ToString();

                bus.EditNS(maNS, tenNS, ngaySinh, nu, chucVu);

                MessageBox.Show("Đã sửa thành công thông tin nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLNS_Load(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("There is no row"))
                {
                    MessageBox.Show("Mã nhân sự này không tồn tại trong bảng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string maNS = txtMaNhanVien.Text;
                if (String.IsNullOrWhiteSpace(maNS)) throw new Exception("Mã nhân sự không được để trống");

                DataTable table = bus.FindNSById(maNS);
                string val = table.Rows[0].ItemArray[0].ToString();
               
                bus.DeleteNSById(maNS);

                MessageBox.Show("Đã xóa thành công thông tin nhân sự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLNS_Load(sender, e);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("There is no row"))
                {
                    MessageBox.Show("Mã nhân sự này không tồn tại trong bảng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
