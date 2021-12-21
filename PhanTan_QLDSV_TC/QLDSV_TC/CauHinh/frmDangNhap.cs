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
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbPhanManh.DataSource = Program.bds_dspm;
            cmbPhanManh.DisplayMember = "TENPM";
            cmbPhanManh.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
            this.txtMatKhau.PasswordChar = '*';

        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc\nBạn xem lại tên của Publisher và tên của CSDL trong chuỗi kết nối\n" + e.Message);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
            cmbPhanManh.SelectedIndex = 0;
            Program.servername = cmbPhanManh.SelectedValue.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và Mật khẩu không để trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0)
            {
                Program.mlogin = "SV";
                Program.password = "123456";
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mloginDN = Program.mlogin;
                Program.passDN = Program.password;
                String lenh = "EXEC LOGIN_SINHVIEN '" + txtTenDangNhap.Text + "', '"+ txtMatKhau.Text +"'";
                Program.myReader = Program.ExecSqlDataReader(lenh);
                if (Program.myReader == null) return;
                if (Program.myReader.HasRows == false)
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác !!!\n", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Read();
                Program.frmChinh.MAGV.Text = "Mã SV: " + Program.myReader.GetString(0);
                Program.frmChinh.HOTEN.Text = "\tHọ tên SV: " + Program.myReader.GetString(1) +" "+ Program.myReader.GetString(2);
                Program.frmChinh.NHOM.Text = "\tLớp: " + Program.myReader.GetString(3)+"  Khoa: "+ cmbPhanManh.Text;
                Program.mgroup = "SV";
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmChinh.HienThiMenu(Program.mgroup);
                Close();
                return;
            }
            Program.mphanmanh = cmbPhanManh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại Tên đăng nhập và Mật khẩu\n", "", MessageBoxButtons.OK);
                return;

            }
            Program.mhoten = Program.myReader.GetString(1);
            Program.mgroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MAGV.Text = "Mã GV: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mhoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mgroup;
            Program.frmChinh.HienThiMenu(Program.mgroup);
            Close();
        }

        private void cmbPhanManh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbPhanManh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }
    }
}
