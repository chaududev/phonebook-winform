using QLDanhBaDu.Service;
using QLDanhBaDu.ViewModel;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSNhom();
            NapDSLienLac();
            NapThongTinLienLac();
        }
        void NapDSNhom()
        {
            var ls = NhomService.GetList();
            nhomViewModelBindingSource.DataSource = ls;
        }
        public NhomViewModel selectedNhom {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }
        void NapDSLienLac()
        {
            if (selectedNhom != null)
            {
                var list = LienLacService.getByNhom(selectedNhom.MaNhom);
                lienLacViewModelBindingSource.DataSource = list;
            }
        }
        public LienLacViewModel selectedLienLac
        {
            get
            {
                return lienLacViewModelBindingSource.Current as LienLacViewModel;
            }
        }
        public void NapThongTinLienLac()
        {
            if (selectedLienLac != null)
            {
                txtTenGoi.Text = selectedLienLac.TenGoi;
                txtDiaChi.Text = selectedLienLac.DiaChi;
                txtEmail.Text = selectedLienLac.Email;
                txtSoDienThoai.Text = selectedLienLac.SoDienThoai;
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new ThemNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSNhom();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa ? ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomService.RemoveNhom(selectedNhom);
                    NapDSNhom();
                }
            }

        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if (selectedLienLac != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa ? ", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    LienLacService.RemoveLienLac(selectedLienLac);
                    NapDSLienLac();
                }
            }
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var f = new ThemLienLac(selectedNhom);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSLienLac();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDSLienLac();
            NapThongTinLienLac();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapThongTinLienLac();
        }

        private void btnTimKiem_Enter_1(object sender, KeyPressEventArgs e)
        {

            var list = LienLacService.getByTen(e.KeyChar.ToString(),selectedNhom.MaNhom);
            lienLacViewModelBindingSource.DataSource = list;
        }

    }
}
