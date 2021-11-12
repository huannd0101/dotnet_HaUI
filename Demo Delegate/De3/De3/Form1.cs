using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string namTotNghiep = txtNamTotNghiep.Text;
                string diemToanKhoa = txtDiemToanKhoa.Text;
                if (String.IsNullOrWhiteSpace(namTotNghiep))
                {
                    throw new Exception("Bạn chưa nhập năm tốt nghiệp");
                }
                if (String.IsNullOrWhiteSpace(diemToanKhoa))
                {
                    throw new Exception("Bạn chưa nhập điểm toàn khóa");
                }
                if (namTotNghiep.Length > 6)
                {
                    throw new Exception("Năm tốt nghiệp lớn hơn 6 ký tự");
                }
                if (diemToanKhoa.Length > 4)
                {
                    throw new Exception("Năm tốt nghiệp lớn hơn 4 ký tự");
                }

                foreach(char c in namTotNghiep)
                {
                    if (Char.IsLetter(c)) throw new Exception("Năm tốt nghiệp chưa đúng định dạng");
                }

                foreach (char c in diemToanKhoa)
                {
                    if (Char.IsLetter(c)) throw new Exception("Điểm toàn khóa chưa đúng định dạng");
                }

                Form2 form = new Form2();
                form.Sender(namTotNghiep, diemToanKhoa);    //Gọi delegate


                //this.Hide();
                this.Visible = false;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}
