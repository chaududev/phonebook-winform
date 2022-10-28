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
    public partial class ThemNhom : Form
    {
        ErrorProvider error;
        public ThemNhom()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }


        private void btnThemNhomOK_Click(object sender, EventArgs e)
        {
            error.Clear();

            if (String.IsNullOrEmpty(txtTenNhom.Text))
            {
                error.SetError(txtTenNhom, "Vui lòng nhập tên nhóm");
                return;
            }
            var n = new Nhom { TenNhom = txtTenNhom.Text };
            if (NhomService.AddNhom(n) == KetQuas.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
