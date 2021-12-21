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
    public partial class frmHocPhi : Form
    {
        String maSV;
        String nienKhoa;
        int hocKy;
        //long soTienCanDong;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            btnTaiHocPhi.Enabled = btnThoat.Enabled = true;
            btnThemHP.Enabled = btnDongHP.Enabled = btnGhi.Enabled = false;
            gcHocPhi.Enabled = gcCT_HocPhi.Enabled = false;

            // TODO: This line of code loads data into the 'dataSetKeToan.CT_DONGHOCPHI' table. You can move, or remove it, as needed.

        }

        private void btnTaiHocPhi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            dataSetKeToan.EnforceConstraints = false;
            this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSHOCPHITableAdapter.Fill(this.dataSetKeToan.SP_DSHOCPHI, txtMaSV.Text);

            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Fill(this.dataSetKeToan.CT_DONGHOCPHI);
            if (bdsDSHocPhi.Count==0) {
                MessageBox.Show("Sinh viên không tồn tại học phí","",MessageBoxButtons.OK);
                return ;
            }
            maSV = txtMaSV.Text;
            gcHocPhi.Enabled = gcCT_HocPhi.Enabled = true;
            btnThemHP.Enabled = btnDongHP.Enabled = true;

        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = btnThoat.Enabled = true;
            btnThemHP.Enabled = btnTaiHocPhi.Enabled = btnDongHP.Enabled = false;
            gcCT_HocPhi.Enabled = false;

            bdsDSHocPhi.AddNew();

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            
            if(gcHocPhi.Enabled == true)
            {
                nienKhoa = ((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])["NIENKHOA"].ToString();
                hocKy = int.Parse(((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])["HOCKY"].ToString());
                String hocPhi = ((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])["HOCPHI"].ToString();
                if (nienKhoa.Length>9)
                {
                    MessageBox.Show("Niên khóa không hợp lệ!", "", MessageBoxButtons.OK);
                } else if(hocKy<1 || hocKy>4)
                {
                    MessageBox.Show("Học kỳ không hợp lệ!", "", MessageBoxButtons.OK);
                } 
                String ghi = "INSERT INTO HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI) VALUES ('"+maSV+"','"+nienKhoa+"',"+hocKy+","+hocPhi+");";
                if(Program.ExecSqlNonQuery(ghi)==0)
                {
                    MessageBox.Show("Đã thêm thành công!!", "", MessageBoxButtons.OK);
                } else MessageBox.Show("Đã thêm thất bại!!", "", MessageBoxButtons.OK);
            }
            else
            {
                long soTienDong = long.Parse(((DataRowView)bdsCT_HocPhi[bdsCT_HocPhi.Position])["SOTIENDONG"].ToString());
                //if (soTienDong>soTienCanDong)
                //{
                //    MessageBox.Show("Số tiền đóng không hợp lệ!", "", MessageBoxButtons.OK);
                //}
                bdsCT_HocPhi.EndEdit();
                bdsCT_HocPhi.ResetCurrentItem();
                this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.Update(this.dataSetKeToan.CT_DONGHOCPHI);

            }
            this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSHOCPHITableAdapter.Fill(this.dataSetKeToan.SP_DSHOCPHI, txtMaSV.Text);

            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Fill(this.dataSetKeToan.CT_DONGHOCPHI);

            gcHocPhi.Enabled =  true;
            gcCT_HocPhi.Enabled = false;
            btnThemHP.Enabled = btnDongHP.Enabled = true;
            btnTaiHocPhi.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnDongHP_Click(object sender, EventArgs e)
        {
            nienKhoa = ((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])["NIENKHOA"].ToString();
            hocKy = int.Parse(((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])["HOCKY"].ToString());
            //soTienCanDong = long.Parse(((DataRowView)bdsDSHocPhi[bdsDSHocPhi.Position])..ToString());

            gcHocPhi.Enabled = false;
            gcCT_HocPhi.Enabled = true;
            btnGhi.Enabled = btnThoat.Enabled = true;
            btnThemHP.Enabled = btnTaiHocPhi.Enabled = btnDongHP.Enabled = false;
            bdsCT_HocPhi.AddNew();
            //((DataRowView)bdsCT_HocPhi[bdsCT_HocPhi.Position])["NGAYDONG"]
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
