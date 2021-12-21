
namespace QLDSV_TC
{
    partial class frmNhapDiem
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
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNIENKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.btnGhiDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTaiLTC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.bdsLAY_DS_LOPTC = new System.Windows.Forms.BindingSource(this.components);
            this.lAY_DS_LOPTCTableAdapter = new QLDSV_TC.DSTableAdapters.LAY_DS_LOPTCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.gc_lAY_DS_LOPTC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDSDangKy = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nIENKHOATableAdapter = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAY_DS_LOPTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_lAY_DS_LOPTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.btnGhiDiem);
            this.panelControl1.Controls.Add(this.btnNhapDiem);
            this.panelControl1.Controls.Add(this.btnTaiLTC);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1594, 93);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNIENKHOA;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(561, 31);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(170, 24);
            this.cmbNienKhoa.TabIndex = 9;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1490, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "HOCKY";
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(848, 31);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(52, 24);
            this.cmbHocKy.TabIndex = 8;
            this.cmbHocKy.ValueMember = "HOCKY";
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Location = new System.Drawing.Point(1349, 26);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(87, 31);
            this.btnGhiDiem.TabIndex = 8;
            this.btnGhiDiem.Text = "Ghi điểm";
            this.btnGhiDiem.UseVisualStyleBackColor = true;
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(1228, 27);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(95, 30);
            this.btnNhapDiem.TabIndex = 7;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Location = new System.Drawing.Point(1014, 25);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(143, 33);
            this.btnTaiLTC.TabIndex = 6;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.UseVisualStyleBackColor = true;
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niên khoá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khoa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(111, 31);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(303, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // bdsLAY_DS_LOPTC
            // 
            this.bdsLAY_DS_LOPTC.DataMember = "LAY_DS_LOPTC";
            this.bdsLAY_DS_LOPTC.DataSource = this.dS;
            // 
            // lAY_DS_LOPTCTableAdapter
            // 
            this.lAY_DS_LOPTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TENGIANGVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gc_lAY_DS_LOPTC
            // 
            this.gc_lAY_DS_LOPTC.DataSource = this.bdsLAY_DS_LOPTC;
            this.gc_lAY_DS_LOPTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_lAY_DS_LOPTC.Location = new System.Drawing.Point(0, 93);
            this.gc_lAY_DS_LOPTC.MainView = this.gridView1;
            this.gc_lAY_DS_LOPTC.Name = "gc_lAY_DS_LOPTC";
            this.gc_lAY_DS_LOPTC.Size = new System.Drawing.Size(1594, 221);
            this.gc_lAY_DS_LOPTC.TabIndex = 3;
            this.gc_lAY_DS_LOPTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN});
            this.gridView1.GridControl = this.gc_lAY_DS_LOPTC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 30;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 140;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 453;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 30;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 112;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Giảng viên giảng dạy";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 30;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 800;
            // 
            // gcDSDangKy
            // 
            this.gcDSDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSDangKy.Location = new System.Drawing.Point(0, 314);
            this.gcDSDangKy.MainView = this.gridView2;
            this.gcDSDangKy.Name = "gcDSDangKy";
            this.gcDSDangKy.Size = new System.Drawing.Size(1594, 331);
            this.gcDSDangKy.TabIndex = 4;
            this.gcDSDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumnCC,
            this.gridColumnGK,
            this.gridColumnCK,
            this.gridColumn6});
            this.gridView2.GridControl = this.gcDSDangKy;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sinh viên";
            this.gridColumn1.FieldName = "MASV";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ và tên sinh viên";
            this.gridColumn2.FieldName = "HOTEN";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumnCC
            // 
            this.gridColumnCC.Caption = "Điểm chuyên cần";
            this.gridColumnCC.DisplayFormat.FormatString = "n0";
            this.gridColumnCC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCC.FieldName = "DIEM_CC";
            this.gridColumnCC.MinWidth = 30;
            this.gridColumnCC.Name = "gridColumnCC";
            this.gridColumnCC.Visible = true;
            this.gridColumnCC.VisibleIndex = 2;
            this.gridColumnCC.Width = 112;
            // 
            // gridColumnGK
            // 
            this.gridColumnGK.Caption = "Điểm giữa kỳ";
            this.gridColumnGK.DisplayFormat.FormatString = "n2";
            this.gridColumnGK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnGK.FieldName = "DIEM_GK";
            this.gridColumnGK.MinWidth = 30;
            this.gridColumnGK.Name = "gridColumnGK";
            this.gridColumnGK.Visible = true;
            this.gridColumnGK.VisibleIndex = 3;
            this.gridColumnGK.Width = 112;
            // 
            // gridColumnCK
            // 
            this.gridColumnCK.Caption = "Điểm cuối kỳ";
            this.gridColumnCK.DisplayFormat.FormatString = "n2";
            this.gridColumnCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCK.FieldName = "DIEM_CK";
            this.gridColumnCK.MinWidth = 30;
            this.gridColumnCK.Name = "gridColumnCK";
            this.gridColumnCK.Visible = true;
            this.gridColumnCK.VisibleIndex = 4;
            this.gridColumnCK.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Điểm hết môn";
            this.gridColumn6.DisplayFormat.FormatString = "n3";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "gridColumn6";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.UnboundDataType = typeof(double);
            this.gridColumn6.UnboundExpression = "[DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 112;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 645);
            this.Controls.Add(this.gcDSDangKy);
            this.Controls.Add(this.gc_lAY_DS_LOPTC);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNIENKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAY_DS_LOPTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_lAY_DS_LOPTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnGhiDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnTaiLTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLAY_DS_LOPTC;
        private DSTableAdapters.LAY_DS_LOPTCTableAdapter lAY_DS_LOPTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_lAY_DS_LOPTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraGrid.GridControl gcDSDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource bdsNIENKHOA;
        private DSTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
    }
}