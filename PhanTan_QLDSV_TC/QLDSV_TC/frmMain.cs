using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            ribDanhMuc.Visible = ribDangKyMonHoc.Visible = ribKeToan.Visible = ribBaoCao.Visible = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
        }
        public void HienThiMenu(string nhom)
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = true;
            if (nhom == "PGV" || nhom == "KHOA")
            {
                ribDanhMuc.Visible = ribBaoCao.Visible = true;
            }
            else if(nhom == "PKT")
            {
                ribKeToan.Visible =  true;
            }
            else
            {
                ribDangKyMonHoc.Visible = true;
                btnTaoTaiKhoan.Enabled = false;
            }
            
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmSinhVien));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmLop));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmLopTinChi));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmMonHoc));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmNhapDiem));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmDangKyMonHoc));
            if (form != null) form.Close();
            form = this.CheckExists(typeof(frmHocPhi));
            if (form != null) form.Close();
            ribDanhMuc.Visible = ribDangKyMonHoc.Visible = ribKeToan.Visible = ribBaoCao.Visible = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
            Program.frmChinh.MAGV.Text = "Mã GV" ;
            Program.frmChinh.HOTEN.Text = "Họ tên ";
            Program.frmChinh.NHOM.Text = "Nhóm ";
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKyMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyMonHoc f = new frmDangKyMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DSLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frm_DSLopTinChi f = new frm_DSLopTinChi();
                f.ShowDialog();
            }
        }

        private void btnDSSVDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DSSVDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frm_DSSVDangKyLTC f = new frm_DSSVDangKyLTC();
                f.ShowDialog();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_BangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frm_BangDiemTongKet f = new frm_BangDiemTongKet();
                f.ShowDialog();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_PhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frm_PhieuDiem f = new frm_PhieuDiem();
                f.ShowDialog();
            }
        }

        private void btnDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSBangDiemLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDSBangDiemLTC f = new frmDSBangDiemLTC();
                f.ShowDialog();
            }
        }

        private void btnDSDongHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSDongHocPhiCuaLop));
            if (frm != null) frm.Activate();
            else
            {
                frmDSDongHocPhiCuaLop f = new frmDSDongHocPhiCuaLop();
                f.ShowDialog();
            }
        }
    }
}
