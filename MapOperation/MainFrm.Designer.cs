namespace MapOperation
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.mainMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataView = new System.Windows.Forms.TabPage();
            this.PageLayoutView = new System.Windows.Forms.TabPage();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barCoorTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AddData = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMXD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadMxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIMapDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.btncontrolsOpenDocCommandClass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddShapefile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRaster = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCAD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCADByLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddWholeCAD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRasterByCAD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPersonGeodatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFileDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSDE = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSDEByService = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSDEByDirect = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveMap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAsMap = new System.Windows.Forms.ToolStripMenuItem();
            this.MapView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomInStep = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomOutStep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFrontView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForWardView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFullView = new System.Windows.Forms.ToolStripMenuItem();
            this.MapExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportMap = new System.Windows.Forms.ToolStripMenuItem();
            this.BookMark = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBookMark = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMangeBookMark = new System.Windows.Forms.ToolStripMenuItem();
            this.MapMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMeasureLength = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMeasureArea = new System.Windows.Forms.ToolStripMenuItem();
            this.MapSel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomToSel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearSel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DataView.SuspendLayout();
            this.PageLayoutView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMapControl2
            // 
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(0, 0);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(228, 263);
            this.axMapControl2.TabIndex = 0;
            // 
            // mainMapControl
            // 
            this.mainMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMapControl.Location = new System.Drawing.Point(3, 3);
            this.mainMapControl.Name = "mainMapControl";
            this.mainMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainMapControl.OcxState")));
            this.mainMapControl.Size = new System.Drawing.Size(650, 507);
            this.mainMapControl.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(228, 275);
            this.axTOCControl1.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(486, 3);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.axLicenseControl1);
            this.splitContainer1.Size = new System.Drawing.Size(896, 542);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.axMapControl2);
            this.splitContainer2.Size = new System.Drawing.Size(228, 542);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.DataView);
            this.tabControl1.Controls.Add(this.PageLayoutView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 542);
            this.tabControl1.TabIndex = 1;
            // 
            // DataView
            // 
            this.DataView.Controls.Add(this.mainMapControl);
            this.DataView.Location = new System.Drawing.Point(4, 4);
            this.DataView.Name = "DataView";
            this.DataView.Padding = new System.Windows.Forms.Padding(3);
            this.DataView.Size = new System.Drawing.Size(656, 513);
            this.DataView.TabIndex = 0;
            this.DataView.Text = "数据视图";
            this.DataView.UseVisualStyleBackColor = true;
            // 
            // PageLayoutView
            // 
            this.PageLayoutView.Controls.Add(this.axPageLayoutControl1);
            this.PageLayoutView.Location = new System.Drawing.Point(4, 4);
            this.PageLayoutView.Name = "PageLayoutView";
            this.PageLayoutView.Padding = new System.Windows.Forms.Padding(3);
            this.PageLayoutView.Size = new System.Drawing.Size(656, 513);
            this.PageLayoutView.TabIndex = 1;
            this.PageLayoutView.Text = "布局视图";
            this.PageLayoutView.UseVisualStyleBackColor = true;
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(650, 507);
            this.axPageLayoutControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 542);
            this.panel1.TabIndex = 3;
            // 
            // barCoorTxt
            // 
            this.barCoorTxt.Name = "barCoorTxt";
            this.barCoorTxt.Size = new System.Drawing.Size(99, 20);
            this.barCoorTxt.Text = "当前坐标为：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barCoorTxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(896, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AddData
            // 
            this.AddData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMXD,
            this.btnAddShapefile,
            this.btnAddRaster,
            this.AddCAD,
            this.btnAddPersonGeodatabase,
            this.btnAddFileDatabase,
            this.AddSDE,
            this.btnAddTxt});
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(81, 24);
            this.AddData.Text = "加载数据";
            // 
            // AddMXD
            // 
            this.AddMXD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadMxFile,
            this.btnIMapDocument,
            this.btncontrolsOpenDocCommandClass});
            this.AddMXD.Name = "AddMXD";
            this.AddMXD.Size = new System.Drawing.Size(290, 26);
            this.AddMXD.Text = "加载MXD";
            // 
            // btnLoadMxFile
            // 
            this.btnLoadMxFile.Name = "btnLoadMxFile";
            this.btnLoadMxFile.Size = new System.Drawing.Size(356, 26);
            this.btnLoadMxFile.Text = "LoadMxFile方法";
            this.btnLoadMxFile.Click += new System.EventHandler(this.btnLoadMxFile_Click);
            // 
            // btnIMapDocument
            // 
            this.btnIMapDocument.Name = "btnIMapDocument";
            this.btnIMapDocument.Size = new System.Drawing.Size(356, 26);
            this.btnIMapDocument.Text = "IMapDocument方法";
            this.btnIMapDocument.Click += new System.EventHandler(this.btnIMapDocument_Click);
            // 
            // btncontrolsOpenDocCommandClass
            // 
            this.btncontrolsOpenDocCommandClass.Name = "btncontrolsOpenDocCommandClass";
            this.btncontrolsOpenDocCommandClass.Size = new System.Drawing.Size(356, 26);
            this.btncontrolsOpenDocCommandClass.Text = "ControlsOpenDocCommandClass方法";
            this.btncontrolsOpenDocCommandClass.Click += new System.EventHandler(this.btncontrolsOpenDocCommandClass_Click);
            // 
            // btnAddShapefile
            // 
            this.btnAddShapefile.Name = "btnAddShapefile";
            this.btnAddShapefile.Size = new System.Drawing.Size(290, 26);
            this.btnAddShapefile.Text = "加载Shapefile数据";
            this.btnAddShapefile.Click += new System.EventHandler(this.btnAddShapefile_Click);
            // 
            // btnAddRaster
            // 
            this.btnAddRaster.Name = "btnAddRaster";
            this.btnAddRaster.Size = new System.Drawing.Size(290, 26);
            this.btnAddRaster.Text = "加载Raster数据";
            this.btnAddRaster.Click += new System.EventHandler(this.btnAddRaster_Click);
            // 
            // AddCAD
            // 
            this.AddCAD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCADByLayer,
            this.btnAddWholeCAD,
            this.btnAddRasterByCAD});
            this.AddCAD.Name = "AddCAD";
            this.AddCAD.Size = new System.Drawing.Size(290, 26);
            this.AddCAD.Text = "加载CAD数据";
            // 
            // btnAddCADByLayer
            // 
            this.btnAddCADByLayer.Name = "btnAddCADByLayer";
            this.btnAddCADByLayer.Size = new System.Drawing.Size(210, 26);
            this.btnAddCADByLayer.Text = "AddCADByLayer";
            this.btnAddCADByLayer.Click += new System.EventHandler(this.btnAddCADByLayer_Click);
            // 
            // btnAddWholeCAD
            // 
            this.btnAddWholeCAD.Name = "btnAddWholeCAD";
            this.btnAddWholeCAD.Size = new System.Drawing.Size(210, 26);
            this.btnAddWholeCAD.Text = "AddWholeCAD";
            this.btnAddWholeCAD.Click += new System.EventHandler(this.btnAddWholeCAD_Click);
            // 
            // btnAddRasterByCAD
            // 
            this.btnAddRasterByCAD.Name = "btnAddRasterByCAD";
            this.btnAddRasterByCAD.Size = new System.Drawing.Size(210, 26);
            this.btnAddRasterByCAD.Text = "AddRasterByCAD";
            this.btnAddRasterByCAD.Click += new System.EventHandler(this.btnAddRasterByCAD_Click);
            // 
            // btnAddPersonGeodatabase
            // 
            this.btnAddPersonGeodatabase.Name = "btnAddPersonGeodatabase";
            this.btnAddPersonGeodatabase.Size = new System.Drawing.Size(290, 26);
            this.btnAddPersonGeodatabase.Text = "加载PersonGeodatabase数据";
            this.btnAddPersonGeodatabase.Click += new System.EventHandler(this.btnAddPersonGeodatabase_Click);
            // 
            // btnAddFileDatabase
            // 
            this.btnAddFileDatabase.Name = "btnAddFileDatabase";
            this.btnAddFileDatabase.Size = new System.Drawing.Size(290, 26);
            this.btnAddFileDatabase.Text = "加载FileDatabase数据";
            // 
            // AddSDE
            // 
            this.AddSDE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSDEByService,
            this.btnAddSDEByDirect});
            this.AddSDE.Name = "AddSDE";
            this.AddSDE.Size = new System.Drawing.Size(290, 26);
            this.AddSDE.Text = "加载SDE数据库";
            // 
            // btnAddSDEByService
            // 
            this.btnAddSDEByService.Name = "btnAddSDEByService";
            this.btnAddSDEByService.Size = new System.Drawing.Size(250, 26);
            this.btnAddSDEByService.Text = "AddSDEBaseOnService";
            // 
            // btnAddSDEByDirect
            // 
            this.btnAddSDEByDirect.Name = "btnAddSDEByDirect";
            this.btnAddSDEByDirect.Size = new System.Drawing.Size(250, 26);
            this.btnAddSDEByDirect.Text = "AddSDEByDirect";
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.Size = new System.Drawing.Size(290, 26);
            this.btnAddTxt.Text = "加载txt文本数据";
            // 
            // Save
            // 
            this.Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveMap,
            this.btnSaveAsMap});
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(51, 24);
            this.Save.Text = "保存";
            // 
            // btnSaveMap
            // 
            this.btnSaveMap.Name = "btnSaveMap";
            this.btnSaveMap.Size = new System.Drawing.Size(159, 26);
            this.btnSaveMap.Text = "保存地图";
            // 
            // btnSaveAsMap
            // 
            this.btnSaveAsMap.Name = "btnSaveAsMap";
            this.btnSaveAsMap.Size = new System.Drawing.Size(159, 26);
            this.btnSaveAsMap.Text = "地图另存为";
            // 
            // MapView
            // 
            this.MapView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnZoomInStep,
            this.btnZoomOutStep,
            this.toolStripSeparator1,
            this.btnPan,
            this.btnFrontView,
            this.btnForWardView,
            this.btnFullView});
            this.MapView.Name = "MapView";
            this.MapView.Size = new System.Drawing.Size(81, 24);
            this.MapView.Text = "地图浏览";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(144, 26);
            this.btnZoomIn.Text = "拉框放大";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(144, 26);
            this.btnZoomOut.Text = "拉框缩小";
            // 
            // btnZoomInStep
            // 
            this.btnZoomInStep.Name = "btnZoomInStep";
            this.btnZoomInStep.Size = new System.Drawing.Size(144, 26);
            this.btnZoomInStep.Text = "逐级放大";
            // 
            // btnZoomOutStep
            // 
            this.btnZoomOutStep.Name = "btnZoomOutStep";
            this.btnZoomOutStep.Size = new System.Drawing.Size(144, 26);
            this.btnZoomOutStep.Text = "逐级缩小";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // btnPan
            // 
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(144, 26);
            this.btnPan.Text = "漫游";
            // 
            // btnFrontView
            // 
            this.btnFrontView.Name = "btnFrontView";
            this.btnFrontView.Size = new System.Drawing.Size(144, 26);
            this.btnFrontView.Text = "前一视图";
            // 
            // btnForWardView
            // 
            this.btnForWardView.Name = "btnForWardView";
            this.btnForWardView.Size = new System.Drawing.Size(144, 26);
            this.btnForWardView.Text = "后一视图";
            // 
            // btnFullView
            // 
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(144, 26);
            this.btnFullView.Text = "全图显示";
            // 
            // MapExport
            // 
            this.MapExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportRegion,
            this.btnExportMap});
            this.MapExport.Name = "MapExport";
            this.MapExport.Size = new System.Drawing.Size(81, 24);
            this.MapExport.Text = "地图导出";
            // 
            // btnExportRegion
            // 
            this.btnExportRegion.Name = "btnExportRegion";
            this.btnExportRegion.Size = new System.Drawing.Size(144, 26);
            this.btnExportRegion.Text = "区域导出";
            // 
            // btnExportMap
            // 
            this.btnExportMap.Name = "btnExportMap";
            this.btnExportMap.Size = new System.Drawing.Size(144, 26);
            this.btnExportMap.Text = "全域导出";
            // 
            // BookMark
            // 
            this.BookMark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBookMark,
            this.btnMangeBookMark});
            this.BookMark.Name = "BookMark";
            this.BookMark.Size = new System.Drawing.Size(81, 24);
            this.BookMark.Text = "书签管理";
            // 
            // btnAddBookMark
            // 
            this.btnAddBookMark.Name = "btnAddBookMark";
            this.btnAddBookMark.Size = new System.Drawing.Size(144, 26);
            this.btnAddBookMark.Text = "添加书签";
            // 
            // btnMangeBookMark
            // 
            this.btnMangeBookMark.Name = "btnMangeBookMark";
            this.btnMangeBookMark.Size = new System.Drawing.Size(144, 26);
            this.btnMangeBookMark.Text = "管理书签";
            // 
            // MapMeasure
            // 
            this.MapMeasure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMeasureLength,
            this.btnMeasureArea});
            this.MapMeasure.Name = "MapMeasure";
            this.MapMeasure.Size = new System.Drawing.Size(81, 24);
            this.MapMeasure.Text = "地图量测";
            // 
            // btnMeasureLength
            // 
            this.btnMeasureLength.Name = "btnMeasureLength";
            this.btnMeasureLength.Size = new System.Drawing.Size(144, 26);
            this.btnMeasureLength.Text = "距离量测";
            // 
            // btnMeasureArea
            // 
            this.btnMeasureArea.Name = "btnMeasureArea";
            this.btnMeasureArea.Size = new System.Drawing.Size(144, 26);
            this.btnMeasureArea.Text = "面积量测";
            // 
            // MapSel
            // 
            this.MapSel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelFeature,
            this.btnZoomToSel,
            this.btnClearSel});
            this.MapSel.Name = "MapSel";
            this.MapSel.Size = new System.Drawing.Size(81, 24);
            this.MapSel.Text = "要素选择";
            // 
            // btnSelFeature
            // 
            this.btnSelFeature.Name = "btnSelFeature";
            this.btnSelFeature.Size = new System.Drawing.Size(159, 26);
            this.btnSelFeature.Text = "要素选择";
            // 
            // btnZoomToSel
            // 
            this.btnZoomToSel.Name = "btnZoomToSel";
            this.btnZoomToSel.Size = new System.Drawing.Size(159, 26);
            this.btnZoomToSel.Text = "缩放至选择";
            // 
            // btnClearSel
            // 
            this.btnClearSel.Name = "btnClearSel";
            this.btnClearSel.Size = new System.Drawing.Size(159, 26);
            this.btnClearSel.Text = "清除选择";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddData,
            this.Save,
            this.MapView,
            this.MapExport,
            this.BookMark,
            this.MapMeasure,
            this.MapSel,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFrm";
            this.Text = "地理数据操作";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DataView.ResumeLayout(false);
            this.PageLayoutView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private ESRI.ArcGIS.Controls.AxMapControl mainMapControl;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataView;
        private System.Windows.Forms.TabPage PageLayoutView;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel barCoorTxt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddData;
        private System.Windows.Forms.ToolStripMenuItem AddMXD;
        private System.Windows.Forms.ToolStripMenuItem btnLoadMxFile;
        private System.Windows.Forms.ToolStripMenuItem btnIMapDocument;
        private System.Windows.Forms.ToolStripMenuItem btncontrolsOpenDocCommandClass;
        private System.Windows.Forms.ToolStripMenuItem btnAddShapefile;
        private System.Windows.Forms.ToolStripMenuItem btnAddRaster;
        private System.Windows.Forms.ToolStripMenuItem AddCAD;
        private System.Windows.Forms.ToolStripMenuItem btnAddCADByLayer;
        private System.Windows.Forms.ToolStripMenuItem btnAddWholeCAD;
        private System.Windows.Forms.ToolStripMenuItem btnAddRasterByCAD;
        private System.Windows.Forms.ToolStripMenuItem btnAddPersonGeodatabase;
        private System.Windows.Forms.ToolStripMenuItem btnAddFileDatabase;
        private System.Windows.Forms.ToolStripMenuItem AddSDE;
        private System.Windows.Forms.ToolStripMenuItem btnAddSDEByService;
        private System.Windows.Forms.ToolStripMenuItem btnAddSDEByDirect;
        private System.Windows.Forms.ToolStripMenuItem btnAddTxt;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem btnSaveMap;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAsMap;
        private System.Windows.Forms.ToolStripMenuItem MapView;
        private System.Windows.Forms.ToolStripMenuItem btnZoomIn;
        private System.Windows.Forms.ToolStripMenuItem btnZoomOut;
        private System.Windows.Forms.ToolStripMenuItem btnZoomInStep;
        private System.Windows.Forms.ToolStripMenuItem btnZoomOutStep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnPan;
        private System.Windows.Forms.ToolStripMenuItem btnFrontView;
        private System.Windows.Forms.ToolStripMenuItem btnForWardView;
        private System.Windows.Forms.ToolStripMenuItem btnFullView;
        private System.Windows.Forms.ToolStripMenuItem MapExport;
        private System.Windows.Forms.ToolStripMenuItem btnExportRegion;
        private System.Windows.Forms.ToolStripMenuItem btnExportMap;
        private System.Windows.Forms.ToolStripMenuItem BookMark;
        private System.Windows.Forms.ToolStripMenuItem btnAddBookMark;
        private System.Windows.Forms.ToolStripMenuItem btnMangeBookMark;
        private System.Windows.Forms.ToolStripMenuItem MapMeasure;
        private System.Windows.Forms.ToolStripMenuItem btnMeasureLength;
        private System.Windows.Forms.ToolStripMenuItem btnMeasureArea;
        private System.Windows.Forms.ToolStripMenuItem MapSel;
        private System.Windows.Forms.ToolStripMenuItem btnSelFeature;
        private System.Windows.Forms.ToolStripMenuItem btnZoomToSel;
        private System.Windows.Forms.ToolStripMenuItem btnClearSel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

