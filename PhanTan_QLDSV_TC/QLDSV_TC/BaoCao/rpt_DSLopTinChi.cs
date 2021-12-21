using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class rpt_DSLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_DSLopTinChi(string NK, int HK)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = NK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = HK;
            this.sqlDataSource1.Fill();
        }

    }
}
