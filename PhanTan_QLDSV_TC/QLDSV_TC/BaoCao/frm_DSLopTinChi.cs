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
    public partial class frm_DSLopTinChi : Form
    {
        public frm_DSLopTinChi()
        {
            InitializeComponent();
        }

        private void frm_DSLopTinChi_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
            if (bdsNIENKHOA.Count == 0)
            {
                MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                btnXemBaoCao.Enabled = false;
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
                if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
                
                btnXemBaoCao.Enabled = true;
                if (bdsNIENKHOA.Count == 0)
                {
                    MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                    btnXemBaoCao.Enabled = false;
                }
            }
        }

        

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            rpt_DSLopTinChi report = new rpt_DSLopTinChi(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            report.lbTuaDe.Text = cmbKhoa.Text.ToUpper();
            report.lbNienKhoa.Text = cmbNienKhoa.Text;
            report.lbHocKy.Text = cmbHocKy.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
