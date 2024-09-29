using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class EmployeeForm : Form
    {
        public string MSNV { get; set; }
        public string TenNhanVien { get; set; }
        public string LuongCanBan { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNhanVien = txtTenNhanVien.Text;
            LuongCanBan = txtLuongCanBan.Text;

            if (string.IsNullOrEmpty(MSNV) || string.IsNullOrEmpty(TenNhanVien) || string.IsNullOrEmpty(LuongCanBan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
