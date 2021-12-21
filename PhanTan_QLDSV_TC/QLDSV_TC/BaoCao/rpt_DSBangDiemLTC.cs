using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class rpt_DSBangDiemLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_DSBangDiemLTC(int maltc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maltc;
            this.sqlDataSource1.Fill();
        }

    }
}
