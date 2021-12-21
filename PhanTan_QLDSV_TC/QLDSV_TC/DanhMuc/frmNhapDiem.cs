using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmNhapDiem : Form
    {
        string maltc;
        DataTable dt_DSDangKy = new DataTable();
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        


        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.lAY_DS_LOPTCTableAdapter.Connection.ConnectionString = Program.connstr;

                this.lAY_DS_LOPTCTableAdapter.Fill(this.dS.LAY_DS_LOPTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                gc_lAY_DS_LOPTC.Enabled = true;
                btnNhapDiem.Enabled = true;
                btnGhiDiem.Enabled = false;
                if (bdsLAY_DS_LOPTC.Count == 0)
                {
                    btnNhapDiem.Enabled = false;
                    gc_lAY_DS_LOPTC.Enabled = false;
                    MessageBox.Show("Học kỳ này chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp tín chỉ: "+ ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            btnTaiLTC.Enabled = true;
            btnNhapDiem.Enabled = btnGhiDiem.Enabled = false;
            gc_lAY_DS_LOPTC.Enabled = false;
            gcDSDangKy.Enabled = false;
            if(bdsNIENKHOA.Count==0)
            {
                MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                btnTaiLTC.Enabled = false;
            }
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

                this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
                if(cmbNienKhoa.Items.Count>0)cmbNienKhoa.SelectedIndex = 0;
                if(cmbHocKy.Items.Count>0)cmbHocKy.SelectedIndex = 0;
                btnTaiLTC.Enabled = true;
                btnNhapDiem.Enabled = btnGhiDiem.Enabled = false;
                gc_lAY_DS_LOPTC.Enabled = false;
                if (bdsNIENKHOA.Count == 0)
                {
                    MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                    btnTaiLTC.Enabled = false;
                }
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            maltc = ((DataRowView)bdsLAY_DS_LOPTC[bdsLAY_DS_LOPTC.Position])["MALTC"].ToString();
            string lenh = "EXEC LAY_DS_SVDangKy_LTC " + maltc;
            dt_DSDangKy = Program.ExecSqlDataTable(lenh);
            gcDSDangKy.DataSource = dt_DSDangKy;
            if(dt_DSDangKy.Rows.Count == 0)
            {
                MessageBox.Show("Lớp tín chỉ chưa có sinh viên đăng ký !!!", "", MessageBoxButtons.OK);
                return;
            }
            btnTaiLTC.Enabled = btnNhapDiem.Enabled = false;
            gcDSDangKy.Enabled = true;
            gc_lAY_DS_LOPTC.Enabled = false;
            btnGhiDiem.Enabled = true;
            btnThoat.Text = "Huỷ";
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int maltcint = int.Parse(maltc);
            for(int i = 0; i<dt_DSDangKy.Rows.Count; i++)
                dt.Rows.Add(maltcint, dt_DSDangKy.Rows[i]["MASV"], dt_DSDangKy.Rows[i]["DIEM_CC"], dt_DSDangKy.Rows[i]["DIEM_GK"], dt_DSDangKy.Rows[i]["DIEM_CK"]);
             
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            Program.KetNoi();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("CAPNHAT_DIEM", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật điểm thành công !", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể cập nhật điểm: " + ex.Message, "", MessageBoxButtons.OK);

            }
            btnTaiLTC.Enabled = btnNhapDiem.Enabled = true;
            gcDSDangKy.Enabled = false;
            gc_lAY_DS_LOPTC.Enabled = true;
            btnGhiDiem.Enabled = false;
            btnThoat.Text = "Thoát";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text.Equals("Huỷ"))
            {
                if (MessageBox.Show("Bạn có thật sự muốn dừng nhập điểm ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.lAY_DS_LOPTCTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.lAY_DS_LOPTCTableAdapter.Fill(this.dS.LAY_DS_LOPTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                    gc_lAY_DS_LOPTC.Enabled = true;
                    gcDSDangKy.Enabled = false;
                    gcDSDangKy.Enabled = false;
                    btnNhapDiem.Enabled = btnTaiLTC.Enabled = true;
                    btnGhiDiem.Enabled = false;

                    btnThoat.Text = "Thoát";
                }

            }
            else if (btnThoat.Text.Equals("Thoát")) Close();
        }

       

    }
}
