
namespace QLDSV_TC
{
    partial class rpt_BangDiemTongKet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(167.3611F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_BangDiemTongKet));
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.xrCrossTabCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabGeneralStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbLop = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKhoaHoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKhoa = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbKhoa,
            this.lbKhoaHoc,
            this.xrLabel3,
            this.lbLop,
            this.xrLabel1,
            this.label1});
            this.ReportHeader.HeightF = 110.5686F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTab1});
            this.Detail.HeightF = 75F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(900F, 30.01302F);
            this.label1.StyleName = "TitleStyle";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseForeColor = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHOÁ";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTab1
            // 
            this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTabCell1,
            this.xrCrossTabCell2,
            this.xrCrossTabCell3,
            this.xrCrossTabCell4,
            this.xrCrossTabCell5,
            this.xrCrossTabCell6,
            this.xrCrossTabCell7,
            this.xrCrossTabCell8,
            this.xrCrossTabCell9});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.Visible = false;
            this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100F),
            crossTabColumnDefinition2});
            crossTabColumnField1.FieldName = "TENMH";
            this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.crossTab1.DataAreaStyleName = "crossTabDataStyle";
            crossTabDataField1.FieldName = "DIEM";
            this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.crossTab1.DataMember = "SP_BANGDIEMTONGKET";
            this.crossTab1.DataSource = this.sqlDataSource1;
            this.crossTab1.GeneralStyleName = "crossTabGeneralStyle";
            this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle";
            this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.crossTab1.Name = "crossTab1";
            crossTabRowDefinition1.Visible = false;
            this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            crossTabRowDefinition1});
            crossTabRowField1.FieldName = "TT";
            this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.crossTab1.SizeF = new System.Drawing.SizeF(367.3611F, 75F);
            this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle";
            // 
            // xrCrossTabCell1
            // 
            this.xrCrossTabCell1.BackColor = System.Drawing.Color.Beige;
            this.xrCrossTabCell1.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell1.ColumnIndex = 0;
            this.xrCrossTabCell1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell1.ForeColor = System.Drawing.Color.Brown;
            this.xrCrossTabCell1.Name = "xrCrossTabCell1";
            this.xrCrossTabCell1.RowIndex = 0;
            this.xrCrossTabCell1.Text = "Mã - Họ tên sinh viên";
            // 
            // xrCrossTabCell2
            // 
            this.xrCrossTabCell2.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell2.ColumnIndex = 1;
            this.xrCrossTabCell2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell2.Name = "xrCrossTabCell2";
            this.xrCrossTabCell2.RowIndex = 1;
            // 
            // xrCrossTabCell3
            // 
            this.xrCrossTabCell3.BackColor = System.Drawing.Color.Beige;
            this.xrCrossTabCell3.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell3.ColumnIndex = 1;
            this.xrCrossTabCell3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell3.ForeColor = System.Drawing.Color.Brown;
            this.xrCrossTabCell3.Name = "xrCrossTabCell3";
            this.xrCrossTabCell3.RowIndex = 0;
            // 
            // xrCrossTabCell4
            // 
            this.xrCrossTabCell4.BackColor = System.Drawing.Color.Beige;
            this.xrCrossTabCell4.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell4.ColumnIndex = 2;
            this.xrCrossTabCell4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell4.ForeColor = System.Drawing.Color.Brown;
            this.xrCrossTabCell4.Name = "xrCrossTabCell4";
            this.xrCrossTabCell4.RowIndex = 0;
            this.xrCrossTabCell4.Text = "Grand Total";
            // 
            // xrCrossTabCell5
            // 
            this.xrCrossTabCell5.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell5.ColumnIndex = 2;
            this.xrCrossTabCell5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell5.Name = "xrCrossTabCell5";
            this.xrCrossTabCell5.RowIndex = 1;
            // 
            // xrCrossTabCell6
            // 
            this.xrCrossTabCell6.BackColor = System.Drawing.Color.White;
            this.xrCrossTabCell6.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell6.ColumnIndex = 0;
            this.xrCrossTabCell6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell6.ForeColor = System.Drawing.Color.Black;
            this.xrCrossTabCell6.Name = "xrCrossTabCell6";
            this.xrCrossTabCell6.RowIndex = 1;
            // 
            // xrCrossTabCell7
            // 
            this.xrCrossTabCell7.BackColor = System.Drawing.Color.Beige;
            this.xrCrossTabCell7.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell7.ColumnIndex = 0;
            this.xrCrossTabCell7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell7.ForeColor = System.Drawing.Color.Brown;
            this.xrCrossTabCell7.Name = "xrCrossTabCell7";
            this.xrCrossTabCell7.RowIndex = 2;
            this.xrCrossTabCell7.Text = "Grand Total";
            // 
            // xrCrossTabCell8
            // 
            this.xrCrossTabCell8.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell8.ColumnIndex = 1;
            this.xrCrossTabCell8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell8.Name = "xrCrossTabCell8";
            this.xrCrossTabCell8.RowIndex = 2;
            // 
            // xrCrossTabCell9
            // 
            this.xrCrossTabCell9.BorderColor = System.Drawing.Color.Black;
            this.xrCrossTabCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell9.ColumnIndex = 2;
            this.xrCrossTabCell9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrCrossTabCell9.Name = "xrCrossTabCell9";
            this.xrCrossTabCell9.RowIndex = 2;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV_TC.Properties.Settings.QLDSV_TCConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_BANGDIEMTONGKET";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "d18cqcn01";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "SP_BANGDIEMTONGKET";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new System.Drawing.Font("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabGeneralStyle
            // 
            this.crossTabGeneralStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.crossTabGeneralStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle.BorderWidth = 1F;
            this.crossTabGeneralStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle.Name = "crossTabGeneralStyle";
            this.crossTabGeneralStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // crossTabHeaderStyle
            // 
            this.crossTabHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.crossTabHeaderStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderStyle.Name = "crossTabHeaderStyle";
            this.crossTabHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle
            // 
            this.crossTabDataStyle.Name = "crossTabDataStyle";
            this.crossTabDataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle
            // 
            this.crossTabTotalStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.crossTabTotalStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.crossTabTotalStyle.Name = "crossTabTotalStyle";
            this.crossTabTotalStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Brown;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(281.9444F, 30.01302F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(47.91669F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "LỚP:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbLop
            // 
            this.lbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.ForeColor = System.Drawing.Color.Brown;
            this.lbLop.LocationFloat = new DevExpress.Utils.PointFloat(329.8611F, 30.01302F);
            this.lbLop.Multiline = true;
            this.lbLop.Name = "lbLop";
            this.lbLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbLop.SizeF = new System.Drawing.SizeF(105.5555F, 23F);
            this.lbLop.StylePriority.UseFont = false;
            this.lbLop.StylePriority.UseForeColor = false;
            this.lbLop.StylePriority.UseTextAlignment = false;
            this.lbLop.Text = "D18CQCN01";
            this.lbLop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Brown;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(435.4167F, 30.01302F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(120.1389F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "-  KHOÁ HỌC:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoaHoc.ForeColor = System.Drawing.Color.Brown;
            this.lbKhoaHoc.LocationFloat = new DevExpress.Utils.PointFloat(555.5555F, 30.01302F);
            this.lbKhoaHoc.Multiline = true;
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKhoaHoc.SizeF = new System.Drawing.SizeF(79.16669F, 23F);
            this.lbKhoaHoc.StylePriority.UseFont = false;
            this.lbKhoaHoc.StylePriority.UseForeColor = false;
            this.lbKhoaHoc.StylePriority.UseTextAlignment = false;
            this.lbKhoaHoc.Text = "2020-2023";
            this.lbKhoaHoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbKhoa
            // 
            this.lbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.ForeColor = System.Drawing.Color.Brown;
            this.lbKhoa.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.01302F);
            this.lbKhoa.Multiline = true;
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKhoa.SizeF = new System.Drawing.SizeF(900F, 23F);
            this.lbKhoa.StylePriority.UseFont = false;
            this.lbKhoa.StylePriority.UseForeColor = false;
            this.lbKhoa.StylePriority.UseTextAlignment = false;
            this.lbKhoa.Text = "KHOA";
            this.lbKhoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rpt_BangDiemTongKet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle,
            this.crossTabHeaderStyle,
            this.crossTabDataStyle,
            this.crossTabTotalStyle});
            this.Version = "21.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell9;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel lbKhoa;
        public DevExpress.XtraReports.UI.XRLabel lbKhoaHoc;
        public DevExpress.XtraReports.UI.XRLabel lbLop;
    }
}
