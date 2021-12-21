using DevExpress.XtraReports.UI;
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
    public partial class frm_PhieuDiem : Form
    {
        public frm_PhieuDiem()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string lenh = "EXEC SP_TIMSV '" + txtMaSV.Text.Trim() + "'";
            SqlDataReader myReader = null;
            SqlCommand sqlcmd = new SqlCommand(lenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();
                
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            myReader.Read();

            rpt_PhieuDiem report = new rpt_PhieuDiem(txtMaSV.Text.Trim());
            report.lbMaSV.Text = txtMaSV.Text;
            report.lbHoTen.Text = myReader.GetString(0);
            report.lbLop.Text = myReader.GetString(1);
            report.lbKhoa.Text = myReader.GetString(2);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
            Program.conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
