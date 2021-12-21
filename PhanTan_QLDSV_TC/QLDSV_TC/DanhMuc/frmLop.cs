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
    public partial class frmLop : Form
    {
        int vitri;
        string makhoa;
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
        private void frmLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            //makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            //CapNhat_MaKhoa();
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            btnGhi.Enabled =  btnPhucHoi.Enabled = false;
            txtMaKhoa.ReadOnly = true;
            gcLop.Enabled = true;
            panelControl2.Enabled = false;
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
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTableAdapter.Fill(dS.LOP);
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                sINHVIENTableAdapter.Fill(dS.SINHVIEN);
                CapNhat_MaKhoa();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelControl2.Enabled = true;
            bdsLop.AddNew();
            txtMaKhoa.Text = MaKhoa();

            btnThem.Enabled = btnXoa.Enabled = btnChinhSua.Enabled = btnThoat.Enabled= btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim().Equals("") || txtTenLop.Text.Trim().Equals("") || txtKhoaHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống các thông tin !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaLop.Text.Length > 10)
            {
                MessageBox.Show("Mã lớp chỉ tối đa 10 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtTenLop.Text.Length > 50)
            {
                MessageBox.Show("Tên lớp chỉ tối đa 50 ký tự !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtKhoaHoc.Text.Length > 9)
            {
                MessageBox.Show("Khoá học chỉ tối đa 9 ký tự (VD: 2020-2021)", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi ghi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
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
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnReload.Enabled = btnChinhSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcLop.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp này do đã tồn tại sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp này ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = false;
        }
    }
}
