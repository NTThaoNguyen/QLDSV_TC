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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void tENGIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTENGIANGVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TENGIANGVIEN' table. You can move, or remove it, as needed.
            this.tENGIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENGIANGVIENTableAdapter.Fill(this.dS.TENGIANGVIEN);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            if (Program.mgroup == "PGV")
            {
                cmbNhomQuyen.Items.Add("PGV");
                cmbNhomQuyen.Items.Add("KHOA");
            }
            else if (Program.mgroup == "KHOA")
            {
                cmbNhomQuyen.Items.Add("KHOA");
            }
            else
            {
                cmbNhomQuyen.Items.Add("PKT");
            }
            cmbNhomQuyen.SelectedIndex = 0;
            cmbGiangVien.SelectedIndex = 0;
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
                this.tENGIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tENGIANGVIENTableAdapter.Fill(this.dS.TENGIANGVIEN);
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo !", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            else if (txtXacNhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtXacNhan.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim() != txtXacNhan.Text.Trim())
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu chưa trùng khớp", "Thông báo !", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            else
            {
                string tenDN = txtTenDangNhap.Text.Trim();
                string mk = txtMatKhau.Text.Trim();
                string quyen = cmbNhomQuyen.Text;
                string user = cmbGiangVien.SelectedValue.ToString();
                String lenh = "sp_TAOTAIKHOAN '" + tenDN + "', '" + mk + "', '" + user + "', '" + quyen + "'";
                
                SqlCommand Sqlcmd = new SqlCommand(lenh, Program.conn);
                Sqlcmd.CommandType = CommandType.Text;
                Sqlcmd.CommandTimeout = 600;
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                try
                {
                    Sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    MessageBox.Show("Tạo Login thành công !", "Thông báo !", MessageBoxButtons.OK);
                    txtTenDangNhap.Text = "";
                    txtXacNhan.Text = "";
                    txtMatKhau.Text = "";
                    cmbGiangVien.SelectedIndex = 0;
                    cmbNhomQuyen.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("server principal"))
                    {
                        MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ex.Message.Contains("User, group, or role"))
                    {
                        MessageBox.Show("Nhân viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    Program.conn.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
