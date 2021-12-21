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
    public partial class frmDSDongHocPhiCuaLop : Form
    {
        public frmDSDongHocPhiCuaLop()
        {
            InitializeComponent();
        }

        private void frmDSDongHocPhiCuaLop_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            
            if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
            if (cmbLop.Items.Count > 0) cmbLop.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
            if (bdsNienKhoa.Count == 0)
            {
                MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                btnXemBC.Enabled = false;
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

                btnXemBC.Enabled = true;
                if (bdsNienKhoa.Count == 0)
                {
                    MessageBox.Show("Khoa chưa mở lớp tín chỉ nào !", "", MessageBoxButtons.OK);
                    btnXemBC.Enabled = false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            rpt_DSDongHocPhiCuaLop rpt = new rpt_DSDongHocPhiCuaLop(cmbLop.SelectedValue.ToString(), cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            rpt.txtKhoa.Text = cmbKhoa.Text;
            rpt.txtMaLop.Text = cmbLop.SelectedValue.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
