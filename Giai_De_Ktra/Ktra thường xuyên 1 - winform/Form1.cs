using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaoThiHongPhuong212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TIENDIEN> list = new List<TIENDIEN>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text;
                string tenKH = txtHoTen.Text;
                string doiTuong = "";
                if (string.IsNullOrWhiteSpace(maKH))
                {
                    throw new Exception("Không để trống mã khách hàng");
                }
                if (string.IsNullOrWhiteSpace(tenKH))
                {
                    throw new Exception("Không để trống tên khách hàng");
                }
                if (rdoHoGiaDinh.Checked)
                {
                    doiTuong = rdoHoGiaDinh.Text;
                }
                else
                {
                    doiTuong = rdoDoanhNghiep.Text;
                }

                foreach (char c in txtChiSoDau.Text.Trim())
                {
                    if (char.IsLetter(c)) throw new Exception("Chỉ số đầu sai định dạng");
                }

                foreach (char c in txtChiSoCuoi.Text.Trim())
                {
                    if (char.IsLetter(c)) throw new Exception("Chỉ số cuối sai định dạng");
                }

                int chiSoDau = int.Parse(txtChiSoDau.Text);
                int chiSoCuoi = int.Parse(txtChiSoCuoi.Text);
                string ngayNop = dtpNgayNopTien.Value.ToString();

                if (string.IsNullOrWhiteSpace(txtChiSoDau.Text) )
                {
                    throw new Exception("Không để chỉ số đầu");
                }
                if (string.IsNullOrWhiteSpace(txtChiSoCuoi.Text))
                {
                    throw new Exception("Không để chỉ số cuối");
                }

                TIENDIEN tienDien = new TIENDIEN(maKH, tenKH, doiTuong, chiSoDau, chiSoCuoi, ngayNop);

                txtSoTien.Text = tienDien.TongTien().ToString();

                lstResult.Items.Add(tienDien.MaKH);
                lstResult.Items[list.Count].SubItems.Add(tienDien.TenKH);
                lstResult.Items[list.Count].SubItems.Add(tienDien.DoiTuong);
                lstResult.Items[list.Count].SubItems.Add(tienDien.ChiSoDau.ToString());
                lstResult.Items[list.Count].SubItems.Add(tienDien.ChiSoCuoi.ToString());
                lstResult.Items[list.Count].SubItems.Add(tienDien.TongTien().ToString());
                lstResult.Items[list.Count].SubItems.Add(tienDien.NgayNop);

                list.Add(tienDien);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while(lstResult.SelectedIndices.Count > 0)
            {
                lstResult.Items.RemoveAt(lstResult.SelectedIndices[0]);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
