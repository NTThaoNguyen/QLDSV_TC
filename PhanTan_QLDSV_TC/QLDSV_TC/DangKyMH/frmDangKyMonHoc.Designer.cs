
namespace QLDSV_TC
{
    partial class frmDangKyMonHoc
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNIENKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.btnTaiLTC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuDK = new System.Windows.Forms.Button();
            this.btnXoaDK = new System.Windows.Forms.Button();
            this.btnThemDK = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.bdsLAY_DSLTC_CHUADK = new System.Windows.Forms.BindingSource(this.components);
            this.lAY_DSLTC_CHUADKTableAdapter = new QLDSV_TC.DSTableAdapters.LAY_DSLTC_CHUADKTableAdapter();
            this.gcLAY_DSLTC_CHUADK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcDangKy = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nIENKHOATableAdapter = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAY_DSLTC_CHUADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLAY_DSLTC_CHUADK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.btnTaiLTC);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1260, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(893, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNIENKHOA;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(129, 24);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(208, 27);
            this.cmbNienKhoa.TabIndex = 4;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
           // bdsNIENKHOA
            // 
            this.bdsNIENKHOA.DataMember = "NIENKHOA";
            this.bdsNIENKHOA.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Location = new System.Drawing.Point(620, 24);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(138, 27);
            this.btnTaiLTC.TabIndex = 4;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.UseVisualStyleBackColor = true;
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kỳ:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(464, 24);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(56, 27);
            this.cmbHocKy.TabIndex = 2;
            this.cmbHocKy.ValueMember = "HOCKY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Niên khoá:";
            // 
            // btnLuuDK
            // 
            this.btnLuuDK.Location = new System.Drawing.Point(1105, 10);
            this.btnLuuDK.Name = "btnLuuDK";
            this.btnLuuDK.Size = new System.Drawing.Size(125, 27);
            this.btnLuuDK.TabIndex = 7;
            this.btnLuuDK.Text = "Lưu đăng ký";
            this.btnLuuDK.UseVisualStyleBackColor = true;
            this.btnLuuDK.Click += new System.EventHandler(this.btnLuuDK_Click);
            // 
            // btnXoaDK
            // 
            this.btnXoaDK.Location = new System.Drawing.Point(957, 10);
            this.btnXoaDK.Name = "btnXoaDK";
            this.btnXoaDK.Size = new System.Drawing.Size(106, 27);
            this.btnXoaDK.TabIndex = 6;
            this.btnXoaDK.Text = "Xoá đăng ký";
            this.btnXoaDK.UseVisualStyleBackColor = true;
            this.btnXoaDK.Click += new System.EventHandler(this.btnXoaDK_Click);
            // 
            // btnThemDK
            // 
            this.btnThemDK.Location = new System.Drawing.Point(794, 10);
            this.btnThemDK.Name = "btnThemDK";
            this.btnThemDK.Size = new System.Drawing.Size(127, 27);
            this.btnThemDK.TabIndex = 5;
            this.btnThemDK.Text = "Thêm đăng ký";
            this.btnThemDK.UseVisualStyleBackColor = true;
            this.btnThemDK.Click += new System.EventHandler(this.btnThemDK_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsLAY_DSLTC_CHUADK
            // 
            this.bdsLAY_DSLTC_CHUADK.DataMember = "LAY_DSLTC_CHUADK";
            this.bdsLAY_DSLTC_CHUADK.DataSource = this.dS;
            // 
            // lAY_DSLTC_CHUADKTableAdapter
            // 
            this.lAY_DSLTC_CHUADKTableAdapter.ClearBeforeFill = true;
            // 
            // gcLAY_DSLTC_CHUADK
            // 
            this.gcLAY_DSLTC_CHUADK.DataSource = this.bdsLAY_DSLTC_CHUADK;
            this.gcLAY_DSLTC_CHUADK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLAY_DSLTC_CHUADK.Location = new System.Drawing.Point(0, 80);
            this.gcLAY_DSLTC_CHUADK.MainView = this.gridView1;
            this.gcLAY_DSLTC_CHUADK.Name = "gcLAY_DSLTC_CHUADK";
            this.gcLAY_DSLTC_CHUADK.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcLAY_DSLTC_CHUADK.Size = new System.Drawing.Size(1260, 394);
            this.gcLAY_DSLTC_CHUADK.TabIndex = 2;
            this.gcLAY_DSLTC_CHUADK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSVTOITHIEU});
            this.gridView1.GridControl = this.gcLAY_DSLTC_CHUADK;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 30;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 114;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 387;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 30;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 107;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Giảng viên giảng dạy";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 30;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 357;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.Caption = "Số lượng tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 30;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.OptionsColumn.ReadOnly = true;
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 4;
            this.colSOSVTOITHIEU.Width = 153;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnLuuDK);
            this.panelControl2.Controls.Add(this.btnXoaDK);
            this.panelControl2.Controls.Add(this.btnThemDK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 474);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1260, 42);
            this.panelControl2.TabIndex = 3;
            // 
            // gcDangKy
            // 
            this.gcDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDangKy.Location = new System.Drawing.Point(0, 516);
            this.gcDangKy.MainView = this.gridView2;
            this.gcDangKy.Name = "gcDangKy";
            this.gcDangKy.Size = new System.Drawing.Size(1260, 320);
            this.gcDangKy.TabIndex = 4;
            this.gcDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gcDangKy;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp tín chỉ";
            this.gridColumn1.FieldName = "MALTC";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên môn học";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 507;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhóm";
            this.gridColumn3.FieldName = "NHOM";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 173;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giảng viên giảng dạy";
            this.gridColumn4.FieldName = "HOTEN";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 408;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 836);
            this.Controls.Add(this.gcDangKy);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcLAY_DSLTC_CHUADK);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDangKyMonHoc";
            this.Text = "Đăng ký môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAY_DSLTC_CHUADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLAY_DSLTC_CHUADK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnTaiLTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.BindingSource bdsLAY_DSLTC_CHUADK;
        private DSTableAdapters.LAY_DSLTC_CHUADKTableAdapter lAY_DSLTC_CHUADKTableAdapter;
        private DevExpress.XtraGrid.GridControl gcLAY_DSLTC_CHUADK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Button btnLuuDK;
        private System.Windows.Forms.Button btnXoaDK;
        private System.Windows.Forms.Button btnThemDK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.BindingSource bdsNIENKHOA;
        private DSTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Button btnThoat;
    }
}