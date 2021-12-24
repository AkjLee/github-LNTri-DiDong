using QLCuahangDD.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuahangDD;
using QLCuahangDD.DAL;
using QLCuahangDD.BLL;
using QLCuahangDD.Properties;

namespace QLCuahangDD
{
    public partial class frmThemCH : Form
    {
        CuahangViewModel Cuahang;
        public frmThemCH()
        {
            InitializeComponent();
            this.Cuahang = Cuahang;
            if (Cuahang == null)
            {
                //Thêm mới cửa hàng
                this.Text = "Thêm mới cửa hàng";
            }
            else
            {   //Cập nhật Cửa hàng
                this.Text = "Cập nhật dữ liệu";
                txtTenCH.Text = Cuahang.Name;
                txtDC.Text = Cuahang.Diachi;
                txtSDT.Text = Cuahang.SDT;
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var cuaHang = txtTenCH.Text;
            var cuaHang2 = txtDC.Text;
            var cuaHang3 = txtSDT.Text;
            QLCuahangModel model = new QLCuahangModel();
            var lh = model.Cuahangs.Where(t => t.Name == cuaHang.ToString()).FirstOrDefault();
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

            if (lh != null)
            {
                MessageBox.Show(" cửa hàng trùng đã tồn tại ", "Chú ý");
                return;
            }
            else
            {
                lh = new Cuahang
                {
                    Name =cuaHang,
                    Diachi = cuaHang2,
                    SDT = cuaHang3

                };
                model.Cuahangs.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show(" thêm thành công");

            }


        }
    }
}
