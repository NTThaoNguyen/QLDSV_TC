
namespace QLDSV_TC
{
    partial class frmHocPhi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDongHP = new System.Windows.Forms.Button();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThemHP = new System.Windows.Forms.Button();
            this.btnTaiHocPhi = new System.Windows.Forms.Button();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.dataSetKeToan = new QLDSV_TC.DataSetKeToan();
            this.bdsDSHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSHOCPHITableAdapter = new QLDSV_TC.DataSetKeToanTableAdapters.SP_DSHOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DataSetKeToanTableAdapters.TableAdapterManager();
            this.cT_DONGHOCPHITableAdapter = new QLDSV_TC.DataSetKeToanTableAdapters.CT_DONGHOCPHITableAdapter();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENCONLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCT_HocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.gcCT_HocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKeToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_HocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDongHP);
            this.panelControl1.Controls.Add(this.lbMaSV);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnGhi);
            this.panelControl1.Controls.Add(this.btnThemHP);
            this.panelControl1.Controls.Add(this.btnTaiHocPhi);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1204, 129);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDongHP
            // 
            this.btnDongHP.Location = new System.Drawing.Point(1125, 54);
            this.btnDongHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongHP.Name = "btnDongHP";
            this.btnDongHP.Size = new System.Drawing.Size(172, 40);
            this.btnDongHP.TabIndex = 8;
            this.btnDongHP.Text = "Đóng học phí";
            this.btnDongHP.UseVisualStyleBackColor = true;
            this.btnDongHP.Click += new System.EventHandler(this.btnDongHP_Click);
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(98, 60);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(91, 17);
            this.lbMaSV.TabIndex = 7;
            this.lbMaSV.Text = "Mã sinh viên: ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1629, 54);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(1344, 56);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(112, 39);
            this.btnGhi.TabIndex = 5;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThemHP
            // 
            this.btnThemHP.Location = new System.Drawing.Point(904, 54);
            this.btnThemHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(172, 40);
            this.btnThemHP.TabIndex = 4;
            this.btnThemHP.Text = "Thêm học phí";
            this.btnThemHP.UseVisualStyleBackColor = true;
            this.btnThemHP.Click += new System.EventHandler(this.btnThemHP_Click);
            // 
            // btnTaiHocPhi
            // 
            this.btnTaiHocPhi.Location = new System.Drawing.Point(678, 54);
            this.btnTaiHocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiHocPhi.Name = "btnTaiHocPhi";
            this.btnTaiHocPhi.Size = new System.Drawing.Size(182, 40);
            this.btnTaiHocPhi.TabIndex = 3;
            this.btnTaiHocPhi.Text = "Tải học phí";
            this.btnTaiHocPhi.UseVisualStyleBackColor = true;
            this.btnTaiHocPhi.Click += new System.EventHandler(this.btnTaiHocPhi_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(268, 57);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(266, 22);
            this.txtMaSV.TabIndex = 2;
            // 
            // dataSetKeToan
            // 
            this.dataSetKeToan.DataSetName = "DataSetKeToan";
            this.dataSetKeToan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSHocPhi
            // 
            this.bdsDSHocPhi.DataMember = "SP_DSHOCPHI";
            this.bdsDSHocPhi.DataSource = this.dataSetKeToan;
            // 
            // sP_DSHOCPHITableAdapter
            // 
            this.sP_DSHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = this.cT_DONGHOCPHITableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DataSetKeToanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_DONGHOCPHITableAdapter
            // 
            this.cT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsDSHocPhi;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocPhi.Location = new System.Drawing.Point(0, 129);
            this.gcHocPhi.MainView = this.gridView1;
            this.gcHocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(1204, 690);
            this.gcHocPhi.TabIndex = 3;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colDADONG,
            this.colSOTIENCONLAI});
            this.gridView1.DetailHeight = 525;
            this.gridView1.GridControl = this.gcHocPhi;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 37;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 141;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 37;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 141;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 37;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 141;
            // 
            // colDADONG
            // 
            this.colDADONG.Caption = "Đã đóng";
            this.colDADONG.FieldName = "DADONG";
            this.colDADONG.MinWidth = 37;
            this.colDADONG.Name = "colDADONG";
            this.colDADONG.OptionsColumn.ReadOnly = true;
            this.colDADONG.Visible = true;
            this.colDADONG.VisibleIndex = 3;
            this.colDADONG.Width = 141;
            // 
            // colSOTIENCONLAI
            // 
            this.colSOTIENCONLAI.Caption = "Số tiền còn lại";
            this.colSOTIENCONLAI.FieldName = "colSOTIENCONLAI";
            this.colSOTIENCONLAI.MinWidth = 37;
            this.colSOTIENCONLAI.Name = "colSOTIENCONLAI";
            this.colSOTIENCONLAI.OptionsColumn.ReadOnly = true;
            this.colSOTIENCONLAI.UnboundDataType = typeof(long);
            this.colSOTIENCONLAI.UnboundExpression = "[HOCPHI] - [DADONG]";
            this.colSOTIENCONLAI.Visible = true;
            this.colSOTIENCONLAI.VisibleIndex = 4;
            this.colSOTIENCONLAI.Width = 141;
            // 
            // bdsCT_HocPhi
            // 
            this.bdsCT_HocPhi.DataMember = "FK_SP_DSHOCPHI_CT_DONGHOCPHI";
            this.bdsCT_HocPhi.DataSource = this.bdsDSHocPhi;
            // 
            // gcCT_HocPhi
            // 
            this.gcCT_HocPhi.DataSource = this.bdsCT_HocPhi;
            this.gcCT_HocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCT_HocPhi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_HocPhi.Location = new System.Drawing.Point(0, 819);
            this.gcCT_HocPhi.MainView = this.gridView2;
            this.gcCT_HocPhi.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_HocPhi.Name = "gcCT_HocPhi";
            this.gcCT_HocPhi.Size = new System.Drawing.Size(1204, 0);
            this.gcCT_HocPhi.TabIndex = 3;
            this.gcCT_HocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridView2.DetailHeight = 525;
            this.gridView2.GridControl = this.gcCT_HocPhi;
            this.gridView2.Name = "gridView2";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.Caption = "Ngày đóng";
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 37;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 141;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.Caption = "Số tiền đóng";
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 37;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 141;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 796);
            this.Controls.Add(this.gcCT_HocPhi);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHocPhi";
            this.Text = "frmHocPhi";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKeToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_HocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DataSetKeToan dataSetKeToan;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThemHP;
        private System.Windows.Forms.Button btnTaiHocPhi;
        private System.Windows.Forms.BindingSource bdsDSHocPhi;
        private DataSetKeToanTableAdapters.SP_DSHOCPHITableAdapter sP_DSHOCPHITableAdapter;
        private DataSetKeToanTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetKeToanTableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENCONLAI;
        private System.Windows.Forms.BindingSource bdsCT_HocPhi;
        private System.Windows.Forms.Button btnDongHP;
        private DevExpress.XtraGrid.GridControl gcCT_HocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
    }
}