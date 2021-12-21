using DevExpress.XtraReports.UI;
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
    public partial class frm_BangDiemTongKet : Form
    {
        public frm_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void frm_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            dS.EnforceConstraints = false;
            this.load_DSLopTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.Load_DSLop' table. You can move, or remove it, as needed.
            this.load_DSLopTableAdapter.Fill(this.dS.Load_DSLop);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            if (bdsload_DSLop.Count > 0) cmbLop.SelectedIndex = 0;
            if(bdsload_DSLop.Count == 0)
            {
                MessageBox.Show("Khoa chưa tồn tại lớp !", "", MessageBoxButtons.OK);
                btnXemBC.Enabled = false;
            }

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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

                this.load_DSLopTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.Load_DSLop' table. You can move, or remove it, as needed.
                this.load_DSLopTableAdapter.Fill(this.dS.Load_DSLop);
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                if (bdsload_DSLop.Count > 0) cmbLop.SelectedIndex = 0;
                btnXemBC.Enabled = true;
                if (bdsload_DSLop.Count == 0)
                {
                    MessageBox.Show("Khoa chưa tồn tại lớp !", "", MessageBoxButtons.OK);
                    btnXemBC.Enabled = false;
                }
            }
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            string lenh = "SELECT KHOAHOC FROM LOP WHERE MALOP = '" + cmbLop.SelectedValue +"'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if (Program.myReader.HasRows == false)
            {
                MessageBox.Show("Lớp không tồn tại !!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            string khoahoc = Program.myReader.GetString(0);
            Program.conn.Close();
            rpt_BangDiemTongKet rpt = new rpt_BangDiemTongKet(cmbLop.SelectedValue.ToString());
            rpt.lbKhoa.Text = cmbKhoa.Text.ToUpper();
            rpt.lbLop.Text = cmbLop.SelectedValue.ToString();
            rpt.lbKhoaHoc.Text = khoahoc;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
