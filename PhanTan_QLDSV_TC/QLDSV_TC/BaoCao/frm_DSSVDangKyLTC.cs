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
    public partial class frm_DSSVDangKyLTC : Form
    {
        public frm_DSSVDangKyLTC()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_DSSVDangKyLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mphanmanh;
            if (Program.mgroup == "PGV") cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            if (cmbNienKhoa.Items.Count > 0) cmbNienKhoa.SelectedIndex = 0;
            if (cmbMonHoc.Items.Count > 0) cmbMonHoc.SelectedIndex = 0;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if(txtNhom.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập nhóm !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string lenh = "SELECT MALTC FROM LOPTINCHI WHERE NIENKHOA = '" + cmbNienKhoa.Text + "' AND HOCKY = " + cmbHocKy.Text + " AND MAMH = '" + cmbMonHoc.SelectedValue + "' AND NHOM = "+txtNhom.Text;
            Program.myReader = Program.ExecSqlDataReader(lenh);
            if(Program.myReader.HasRows == false)
            {
                MessageBox.Show("Lớp tín chỉ này chưa được mở !!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            Program.myReader.Read();
            int maltc = Program.myReader.GetInt32(0);
            Program.conn.Close();
            rpt_DSSVDangKyLTC rpt = new rpt_DSSVDangKyLTC(maltc);
            rpt.lbKhoa.Text = cmbKhoa.Text;
            rpt.lbNienKhoa.Text = cmbNienKhoa.Text;
            rpt.lbHocKy.Text = cmbHocKy.Text;
            rpt.lbMonHoc.Text = cmbMonHoc.Text;
            rpt.lbNhom.Text = txtNhom.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbNhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
