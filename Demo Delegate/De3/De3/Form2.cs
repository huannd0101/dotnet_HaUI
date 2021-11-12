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
    public partial class Form2 : Form
    {
        public delegate void SendMessage(string Message, String Message2);
        public SendMessage Sender;
        String s1, s2;
        public Form2()
        {
            InitializeComponent();
            //Tạo con trỏ tới hàm GetMessage
            Sender = new SendMessage(GetMessage);
        }

        private void GetMessage(string Message, string Message2)
        {
            s1 = Message;
            s2 = Message2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            txtNamTotNghiep.Text = s1;
            txtDiemToanKhoa.Text = s2;
        }
    }
}
