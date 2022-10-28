using QLDanhBaDu.Model;
using QLDanhBaDu.ViewModel;
using QLDanhBaDu.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDanhBaDu
{
    public partial class ThemLienLac : Form
    {
        ErrorProvider error;
        public ThemLienLac(NhomViewModel nhom=null)
        {
            InitializeComponent();
            NapDSNhom();
            error = new ErrorProvider();
        }
        void NapDSNhom()
        {
            var ls = NhomService.GetList();
            cbbNhom.DataSource = ls;
            cbbNhom.DisplayMember = "TenNhom";
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbNhom.SelectedItem as NhomViewModel;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (String.IsNullOrEmpty(btnTenGoi.Text))
            {
                error.SetError(btnTenGoi, "Vui lòng nhập tên gọi");
                return;
            }
            else if (String.IsNullOrEmpty(btnSoDienThoai.Text))
            {
                error.SetError(btnSoDienThoai, "Vui lòng nhập số điện thoại");
                return;
            }
            else { 
            var ll = new LienLac { TenGoi=btnTenGoi.Text, DiaChi=btnDiaChi.Text, Email=btnEmail.Text, SoDienThoai=btnSoDienThoai.Text, MaNhom=selectedNhom.MaNhom
            };
            if (LienLacService.AddLienLac(ll) == 1)
            {
                DialogResult = DialogResult.OK;
            }
            }
        }
    }
}
