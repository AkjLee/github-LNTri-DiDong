using QLCuahangDD.BLL;
using QLCuahangDD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuahangDD.ViewModel;

namespace QLCuahangDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapCuahang();
        }

        void NapCuahang()
        {
            var ls = cuahangBLL.GetListViewModel();
            cuahangBindingSource.DataSource = ls;
            dataGridView1.DataSource = cuahangBindingSource;
        }
        public void get()
        {
            QLCuahangModel model = new QLCuahangModel();

            var rows = model.Cuahangs.Select(row => row);
            cuahangBindingSource.DataSource = rows;
            dataGridView1.DataSource = cuahangBindingSource;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var Cuahang = cuahangBindingSource.Current as CuahangViewModel;
            if (Cuahang != null)
            {
                cuahangBLL.Delete(Cuahang.Name);
                MessageBox.Show("ĐÃ XÓA ThÀNH CÔNG", "Thông báo");
                NapCuahang();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemCH();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapCuahang();
            }
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int i;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = dataGridView1.CurrentRow.Index;
           lbl.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
       //     ID = lblText.Text.ToString();
          //  IDtest = ID;
          textBox1.Text= dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           if (
           String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text))

            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa");

            }
           else {
                QLCuahangModel model = new QLCuahangModel();
                var lh = model.Cuahangs.Where(t => t.Name == lbl.Text).FirstOrDefault();
                //   var max = txtSDT.Text;

                /*    if (String.IsNullOrEmpty(cuaHang))
                    {
                        errorProvider1.SetError(txtTenCH, "Vui lòng nhập tên cửa hàng");
                        errorProvider1.SetError(txtDC, "Vui lòng nhập địa chỉ cửa hàng");
                        errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại");
                        return;
                    }
                */

                // Thêm mới

                lh.Name = textBox1.Text;
                lh.Diachi = textBox2.Text;
                lh.SDT = textBox3.Text;
                model.Cuahangs.Add(lh);

                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thông tin cửa hàng thành công");
                NapCuahang();
            }

         

            

        }

        private void cuahangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
