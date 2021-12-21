using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmSinhVien : Form
    {
        String makhoa;
        int vitri;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        { 
    
            // TODO: This line of code loads data into the 'dS.Load_DSLop' table. You can move, or remove it, as needed.

            dS.EnforceConstraints = false;
            this.load_DSLopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.load_DSLopTableAdapter.Fill(this.dS.Load_DSLop);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //CapNhat_MaKhoa();
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoi.Enabled = false;
            gcSinhVien.Enabled = true;
            panelControl2.Enabled = false;

        }
        void CapNhat_MaKhoa()
        {
            String strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
        }
        String MaKhoa()
        {
            String strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return "";
            }
            Program.myReader.Read();
            makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
            return makhoa;
        }
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            if (cmbKhoa.SelectedIndex == 2)
            {
                MessageBox.Show("Không được phép truy cập đến phòng Kế Toán !", "", MessageBoxButtons.OK);

                return;
            }
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mphanmanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về khoa mới !", "", MessageBoxButtons.OK);
            }
            else
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                this.load_DSLopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.load_DSLopTableAdapter.Fill(this.dS.Load_DSLop);
                //CapNhat_MaKhoa();
            }
        }

        private void btnThemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bdsSinhVien.Position;
            panelControl2.Enabled = true;
            bdsSinhVien.AddNew();

            btnThemSV.Enabled = btnXoaSV.Enabled= btnSuaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSinhVien.Enabled = false;
        }

        private void btnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSinhVien.Position;
            panelControl2.Enabled = true;

            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSinhVien.Enabled = false;
        }

        private void btnGhiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sinh viên không được trống !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtHo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ không được trống !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên không được trống !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMatKhau.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không được trống !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaSV.Text.Length >10)
            {
                MessageBox.Show("Mã sinh viên chỉ tối đa 10 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtHo.Text.Length > 50)
            {
                MessageBox.Show("Họ chỉ tối đa 50 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên chỉ tối đa 10 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ tối đa 100 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMatKhau.Text.Length > 40)
            {
                MessageBox.Show("Mật khẩu chỉ tối đa 40 ký tự !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!txtMatKhau.Text.Equals(txtXacNhan.Text))
            {
                MessageBox.Show("Mật khẩu và xác nhận không khớp !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSinhVien.Enabled = true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xoá sinh viên này do đã đăng ký môn học", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá sinh viên này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                    return;
                }
            }
            if (bdsSinhVien.Count == 0) btnXoaSV.Enabled = false;
        }

        private void btnPhucHoiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            if (btnThemSV.Enabled == false) bdsLop.Position = vitri;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnReloadSV.Enabled = btnXoaSV.Enabled = btnGhiSV.Enabled = btnThoatSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
            gcSinhVien.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnReloadSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

    }
}
