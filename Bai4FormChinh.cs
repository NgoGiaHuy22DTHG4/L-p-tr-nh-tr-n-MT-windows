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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm ();
            if (employeeForm.ShowDialog() == DialogResult.OK )
            {
                string MSNV = employeeForm.MSNV;
                string TenNhanVien = employeeForm.TenNhanVien;
                string LuongCanBan = employeeForm.LuongCanBan;
                dataGridView1.Rows.Add(MSNV, TenNhanVien, LuongCanBan);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                EmployeeForm employeeForm = new EmployeeForm();

                employeeForm.MSNV = row.Cells[0].Value.ToString();
                employeeForm.TenNhanVien = row.Cells[1].Value.ToString();
                employeeForm.LuongCanBan = row.Cells[2].Value.ToString();

                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = employeeForm.MSNV;
                    row.Cells[1].Value = employeeForm.TenNhanVien; 
                    row.Cells[2].Value = employeeForm.LuongCanBan;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa. ");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
