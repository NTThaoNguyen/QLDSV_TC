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
    
    public partial class frmDangKyMonHoc : Form
    {
        string masv = Program.frmChinh.MAGV.Text.Substring(7);
        DataTable dt_DangKy = new DataTable();
        public frmDangKyMonHoc()
        {
            InitializeComponent();
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            // TODO: This line of code loads data into the 'dS.LAY_NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
            btnTaiLTC.Enabled = true;
            gcLAY_DSLTC_CHUADK.Enabled = false;
            if (bdsNIENKHOA.Count == 0)
            {
                MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                btnTaiLTC.Enabled = false;
            }
            btnThemDK.Enabled = btnXoaDK.Enabled = btnLuuDK.Enabled = false;
            gcDangKy.Enabled = false;
            dt_DangKy.Columns.Add("MALTC", typeof(int));
            dt_DangKy.Columns.Add("TENMH", typeof(string));
            dt_DangKy.Columns.Add("NHOM", typeof(int));
            dt_DangKy.Columns.Add("HOTEN", typeof(string));
        }

       

        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.lAY_DSLTC_CHUADKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lAY_DSLTC_CHUADKTableAdapter.Fill(this.dS.LAY_DSLTC_CHUADK, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), masv);
                gcLAY_DSLTC_CHUADK.Enabled = true;
                btnThemDK.Enabled = btnTaiLTC.Enabled = true;
                btnLuuDK.Enabled = btnXoaDK.Enabled = false;
                gcDangKy.Enabled = false;
                if (bdsLAY_DSLTC_CHUADK.Count == 0)
                {
                    gcLAY_DSLTC_CHUADK.Enabled = false;
                    btnThemDK.Enabled = false;
                    MessageBox.Show("Học kỳ này chưa mở Lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                }
                dt_DangKy.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThemDK_Click(object sender, EventArgs e)
        {
            int maLTC = int.Parse(((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["MALTC"].ToString());
            bdsLAY_DSLTC_CHUADK.RemoveCurrent();
            string lenh = "EXEC LAY_LOPTINCHI " + maLTC;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            
            Program.myReader.Read();
            dt_DangKy.Rows.Add(maLTC, Program.myReader.GetString(1),Program.myReader.GetInt32(2), Program.myReader.GetString(3));
            Program.conn.Close();
            gcDangKy.DataSource = dt_DangKy;
            btnXoaDK.Enabled = btnLuuDK.Enabled = true;
            gcDangKy.Enabled = true;
            
        }

        private void btnXoaDK_Click(object sender, EventArgs e)
        {
            
            int maltc = (int)dt_DangKy.Rows[gridView2.GetSelectedRows()[0]]["MALTC"];
            dt_DangKy.Rows[gridView2.GetSelectedRows()[0]].Delete();
            bdsLAY_DSLTC_CHUADK.AddNew();
            string lenh = "EXEC LAY_LOPTINCHI " + maltc;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            Program.myReader.Read();
            ((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["MALTC"] = maltc;
            ((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["TENMH"] = Program.myReader.GetString(1);
            ((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["NHOM"] = Program.myReader.GetInt32(2);
            ((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["HOTEN"] = Program.myReader.GetString(3);
            ((DataRowView)bdsLAY_DSLTC_CHUADK[bdsLAY_DSLTC_CHUADK.Position])["SOSVTOITHIEU"] = Program.myReader.GetInt16(4);
            Program.conn.Close();
            gcDangKy.DataSource = dt_DangKy;
            if(dt_DangKy.Rows.Count == 0)
            {
                btnLuuDK.Enabled = btnXoaDK.Enabled = false;
                gcDangKy.Enabled = false;
            }
        }

        
        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            for (int i = 0; i < dt_DangKy.Rows.Count; i++)
                dt.Rows.Add(dt_DangKy.Rows[i]["MALTC"], masv);
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
                MessageBox.Show("Lưu đăng ký thành công !", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu đăng ký: " + ex.Message, "", MessageBoxButtons.OK);

            }
            this.lAY_DSLTC_CHUADKTableAdapter.Connection.ConnectionString = Program.connstr;

            this.lAY_DSLTC_CHUADKTableAdapter.Fill(this.dS.LAY_DSLTC_CHUADK, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), masv);
            gcLAY_DSLTC_CHUADK.Enabled = true;
            btnThemDK.Enabled = btnTaiLTC.Enabled = true;
            btnLuuDK.Enabled = btnXoaDK.Enabled = false;
            gcDangKy.Enabled = false;
            if (bdsLAY_DSLTC_CHUADK.Count == 0)
            {
                gcLAY_DSLTC_CHUADK.Enabled = false;
                btnThemDK.Enabled = false;
            }
            dt_DangKy.Rows.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(dt_DangKy.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự dừng đăng ký ???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Close();
                }
                else return;
            }
            Close();
        }
    }
}
