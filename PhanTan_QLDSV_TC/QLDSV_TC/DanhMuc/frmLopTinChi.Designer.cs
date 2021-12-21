
namespace QLDSV_TC
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mALTCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.dS = new QLDSV_TC.DS();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.DSTableAdapters.LOPTINCHITableAdapter();
            this.gcLTC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.mONHOCComboBox = new System.Windows.Forms.ComboBox();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.tENGIANGVIENComboBox = new System.Windows.Forms.ComboBox();
            this.bdsTENGIANGVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.check_HuyLop = new DevExpress.XtraEditors.CheckEdit();
            this.txtSoSVToiThieu = new DevExpress.XtraEditors.TextEdit();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLTC = new DevExpress.XtraEditors.TextEdit();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.mONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.tENGIANGVIENTableAdapter = new QLDSV_TC.DSTableAdapters.TENGIANGVIENTableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mALTCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENGIANGVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_HuyLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSVToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(84, 75);
            nIENKHOALabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(91, 19);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "Niên khóa: ";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(107, 115);
            hOCKYLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(68, 19);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học kỳ: ";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(110, 164);
            nHOMLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(63, 19);
            nHOMLabel.TabIndex = 6;
            nHOMLabel.Text = "Nhóm: ";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(422, 33);
            sOSVTOITHIEULabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(169, 19);
            sOSVTOITHIEULabel.TabIndex = 8;
            sOSVTOITHIEULabel.Text = "Số sinh viên tối thiểu: ";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(521, 79);
            hUYLOPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(70, 19);
            hUYLOPLabel.TabIndex = 10;
            hUYLOPLabel.Text = "Hủy lớp:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(516, 120);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(75, 19);
            mAMHLabel.TabIndex = 15;
            mAMHLabel.Text = "Môn học:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(501, 164);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(90, 19);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "Giảng viên:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(1692, 48);
            mAKHOALabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(74, 19);
            mAKHOALabel.TabIndex = 17;
            mAKHOALabel.Text = "Mã khoa:";
            // 
            // mALTCLabel
            // 
            mALTCLabel.AutoSize = true;
            mALTCLabel.Location = new System.Drawing.Point(60, 33);
            mALTCLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mALTCLabel.Name = "mALTCLabel";
            mALTCLabel.Size = new System.Drawing.Size(115, 19);
            mALTCLabel.TabIndex = 0;
            mALTCLabel.Text = "Mã lớp tín chỉ: ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 7;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1530, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 798);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1530, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 743);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1530, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 743);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.Khoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1530, 78);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(366, 27);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(6);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(688, 27);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(228, 33);
            this.Khoa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(44, 19);
            this.Khoa.TabIndex = 0;
            this.Khoa.Text = "Khoa";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.dS;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // gcLTC
            // 
            this.gcLTC.DataSource = this.bdsLTC;
            this.gcLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLTC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcLTC.Location = new System.Drawing.Point(0, 133);
            this.gcLTC.MainView = this.gridView1;
            this.gcLTC.Margin = new System.Windows.Forms.Padding(6);
            this.gcLTC.MenuManager = this.barManager1;
            this.gcLTC.Name = "gcLTC";
            this.gcLTC.Size = new System.Drawing.Size(1530, 338);
            this.gcLTC.TabIndex = 11;
            this.gcLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.DetailHeight = 787;
            this.gridView1.GridControl = this.gcLTC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã LTC";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 55;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 211;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 55;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 211;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 55;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 211;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 55;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 211;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 55;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 211;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giảng viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 55;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 211;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 55;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 211;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 55;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 211;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.Caption = "Hủy lớp";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 55;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 211;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbHocKy);
            this.panelControl2.Controls.Add(this.mONHOCComboBox);
            this.panelControl2.Controls.Add(this.tENGIANGVIENComboBox);
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(this.txtMaKhoa);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(hUYLOPLabel);
            this.panelControl2.Controls.Add(this.check_HuyLop);
            this.panelControl2.Controls.Add(sOSVTOITHIEULabel);
            this.panelControl2.Controls.Add(this.txtSoSVToiThieu);
            this.panelControl2.Controls.Add(nHOMLabel);
            this.panelControl2.Controls.Add(this.txtNhom);
            this.panelControl2.Controls.Add(hOCKYLabel);
            this.panelControl2.Controls.Add(nIENKHOALabel);
            this.panelControl2.Controls.Add(this.txtNienKhoa);
            this.panelControl2.Controls.Add(mALTCLabel);
            this.panelControl2.Controls.Add(this.txtMaLTC);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 471);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1530, 327);
            this.panelControl2.TabIndex = 12;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLTC, "HOCKY", true));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(185, 112);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(181, 27);
            this.cmbHocKy.TabIndex = 19;
            // 
            // mONHOCComboBox
            // 
            this.mONHOCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLTC, "MAMH", true));
            this.mONHOCComboBox.DataSource = this.bdsMONHOC;
            this.mONHOCComboBox.DisplayMember = "TENMH";
            this.mONHOCComboBox.FormattingEnabled = true;
            this.mONHOCComboBox.Location = new System.Drawing.Point(603, 117);
            this.mONHOCComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.mONHOCComboBox.Name = "mONHOCComboBox";
            this.mONHOCComboBox.Size = new System.Drawing.Size(275, 27);
            this.mONHOCComboBox.TabIndex = 18;
            this.mONHOCComboBox.ValueMember = "MAMH";
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dS;
            // 
            // tENGIANGVIENComboBox
            // 
            this.tENGIANGVIENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTENGIANGVIEN, "HOTEN", true));
            this.tENGIANGVIENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLTC, "MAGV", true));
            this.tENGIANGVIENComboBox.DataSource = this.bdsTENGIANGVIEN;
            this.tENGIANGVIENComboBox.DisplayMember = "HOTEN";
            this.tENGIANGVIENComboBox.FormattingEnabled = true;
            this.tENGIANGVIENComboBox.Location = new System.Drawing.Point(603, 160);
            this.tENGIANGVIENComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.tENGIANGVIENComboBox.Name = "tENGIANGVIENComboBox";
            this.tENGIANGVIENComboBox.Size = new System.Drawing.Size(275, 27);
            this.tENGIANGVIENComboBox.TabIndex = 18;
            this.tENGIANGVIENComboBox.ValueMember = "MAGV";
            // 
            // bdsTENGIANGVIEN
            // 
            this.bdsTENGIANGVIEN.DataMember = "TENGIANGVIEN";
            this.bdsTENGIANGVIEN.DataSource = this.dS;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(1872, 40);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(194, 26);
            this.txtMaKhoa.TabIndex = 18;
            // 
            // check_HuyLop
            // 
            this.check_HuyLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HUYLOP", true));
            this.check_HuyLop.Location = new System.Drawing.Point(603, 75);
            this.check_HuyLop.Margin = new System.Windows.Forms.Padding(6);
            this.check_HuyLop.MenuManager = this.barManager1;
            this.check_HuyLop.Name = "check_HuyLop";
            this.check_HuyLop.Properties.Caption = "";
            this.check_HuyLop.Size = new System.Drawing.Size(212, 27);
            this.check_HuyLop.TabIndex = 11;
            // 
            // txtSoSVToiThieu
            // 
            this.txtSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "SOSVTOITHIEU", true));
            this.txtSoSVToiThieu.Location = new System.Drawing.Point(603, 30);
            this.txtSoSVToiThieu.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoSVToiThieu.MenuManager = this.barManager1;
            this.txtSoSVToiThieu.Name = "txtSoSVToiThieu";
            this.txtSoSVToiThieu.Size = new System.Drawing.Size(158, 26);
            this.txtSoSVToiThieu.TabIndex = 9;
            this.txtSoSVToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoSVToiThieu_KeyPress);
            // 
            // txtNhom
            // 
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.txtNhom.Location = new System.Drawing.Point(185, 161);
            this.txtNhom.Margin = new System.Windows.Forms.Padding(6);
            this.txtNhom.MenuManager = this.barManager1;
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(181, 26);
            this.txtNhom.TabIndex = 7;
            this.txtNhom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhom_KeyPress);
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(187, 72);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(6);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(179, 26);
            this.txtNienKhoa.TabIndex = 3;
            // 
            // txtMaLTC
            // 
            this.txtMaLTC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MALTC", true));
            this.txtMaLTC.Location = new System.Drawing.Point(187, 30);
            this.txtMaLTC.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaLTC.MenuManager = this.barManager1;
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Size = new System.Drawing.Size(179, 26);
            this.txtMaLTC.TabIndex = 1;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDangKy.DataSource = this.bdsLTC;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tENGIANGVIENTableAdapter
            // 
            this.tENGIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 818);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcLTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLopTinChi";
            this.Text = "Lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENGIANGVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_HuyLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSVToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label Khoa;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit check_HuyLop;
        private DevExpress.XtraEditors.TextEdit txtSoSVToiThieu;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraGrid.GridControl gcLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaLTC;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsTENGIANGVIEN;
        private DSTableAdapters.TENGIANGVIENTableAdapter tENGIANGVIENTableAdapter;
        private System.Windows.Forms.ComboBox tENGIANGVIENComboBox;
        private System.Windows.Forms.ComboBox mONHOCComboBox;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private System.Windows.Forms.ComboBox cmbHocKy;
    }
}