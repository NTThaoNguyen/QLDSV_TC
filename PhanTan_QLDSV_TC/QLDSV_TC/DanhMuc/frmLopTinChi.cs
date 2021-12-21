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
    public partial class frmLopTinChi : Form
    {
        int vitri;
        string maLTC;
        string makhoa;
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TENGIANGVIEN' table. You can move, or remove it, as needed.
             dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.tENGIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENGIANGVIENTableAdapter.Fill(this.dS.TENGIANGVIEN);
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMaLTC.ReadOnly = true;
            gcLTC.Enabled = true;
            panelControl2.Enabled = false;

        }
        string MaKhoa()
        {
            string strLenh = "SELECT MAKHOA FROM KHOA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                Program.conn.Close();
                return "";
            }
            Program.myReader.Read();
            string makhoa = Program.myReader.GetString(0);
            Program.conn.Close();
            return makhoa;

        }
        private void lOPTINCHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl2.Enabled = true;
            bdsLTC.AddNew();
            txtMaKhoa.Text = MaKhoa();
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLTC.Enabled = false;
            cmbHocKy.SelectedIndex = 0;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLTC.Enabled = false;
            cmbHocKy.SelectedIndex = 0;
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
                lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTINCHITableAdapter.Fill(dS.LOPTINCHI);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNienKhoa.Text.Trim().Equals("") || txtNhom.Text.Trim().Equals(""))
            {
                MessageBox.Show("Niên khoá, Học kỳ, Nhóm không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtSoSVToiThieu.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số lượng tối thiểu !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(txtNienKhoa.Text.Length > 9)
            {
                MessageBox.Show("Niên khoá chỉ tối đa 9 ký tự !!! (VD: 2020-2021)", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLTC.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLTC = ((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString();
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp này do đã tồn tại đăng ký", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp tín chỉ này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MALTC", maLTC);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false) bdsLTC.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcLTC.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtHocKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoSVToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
