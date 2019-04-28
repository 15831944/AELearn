﻿using AddFile;
using MapViewControl;
using Model;
using SaveMxd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapOperation
{
    public partial class MainFrm : Form
    {
        #region 全局变量
        AddMxdHelper addMxdHelper;
        ViewControlHelper viewControlHelper;

        IToolRunControl toolRunControl;
        #endregion

        #region 初始化
        public MainFrm()
        {
            InitializeComponent();
            addMxdHelper = new AddMxdHelper();
            viewControlHelper = new ViewControlHelper();
            toolRunControl = null;
        }
        #endregion

        #region 各种为文件加载
        #region 地图文档加载
        #region 控件方法加载地图文档
        private void btnLoadMxFile_Click(object sender, EventArgs e)
        {
            addMxdHelper.LoadMxFile(mainMapControl);
        }
        #endregion

        #region IMapDocument接口方法加载
        private void btnIMapDocument_Click(object sender, EventArgs e)
        {
            addMxdHelper.IMapDocumentLoadMxd(mainMapControl);
        }
        #endregion

        #region ICommand接口加载地图文档
        private void btncontrolsOpenDocCommandClass_Click(object sender, EventArgs e)
        {
            addMxdHelper.ICommandLoadMxd(mainMapControl);
        }
        #endregion

        #endregion

        #region shp文件加载
        private void btnAddShapefile_Click(object sender, EventArgs e)
        {
            AddShpHelper addShpHelper = new AddShpHelper();
            addShpHelper.AddShpFile(mainMapControl);
        }
        #endregion

        #region 栅格数据加载
        private void btnAddRaster_Click(object sender, EventArgs e)
        {
            AddRasterHelper addRasterHelper = new AddRasterHelper();
            addRasterHelper.AddRasterFile(mainMapControl);
        }
        #endregion

        #region CAD数据加载
        #region CAD数据单独添加
        private void btnAddCADByLayer_Click(object sender, EventArgs e)
        {
            AddCADHelper addCADHelper = new AddCADHelper();
            addCADHelper.AddCADByShp(mainMapControl);
        }
        #endregion

        #region CAD数据整体添加
        private void btnAddWholeCAD_Click(object sender, EventArgs e)
        {
            AddCADHelper addCADHelper = new AddCADHelper();
            addCADHelper.AddWholeCAD(mainMapControl);
        }
        #endregion

        #region CAD作为栅格背景图加载
        private void btnAddRasterByCAD_Click(object sender, EventArgs e)
        {
            AddCADHelper addCADHelper = new AddCADHelper();
            addCADHelper.AddCADByRaster(mainMapControl);
        }
        #endregion

        #endregion

        #region mdb加载
        private void btnAddPersonGeodatabase_Click(object sender, EventArgs e)
        {
            AddMdbHelper addMdbHelper = new AddMdbHelper();
            addMdbHelper.AddMdb(mainMapControl);
        }
        #endregion

        #region 加载文件数据库
        private void btnAddFileDatabase_Click(object sender, EventArgs e)
        {
            AddFolderDbHelper addFolderDbHelper = new AddFolderDbHelper();
            addFolderDbHelper.AddFileDb(mainMapControl);
        }
        #endregion

        #region SDE加载
        #region SDE数据库方式加载
        private void btnAddSDEByService_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没做SDE数据库，这个功能就没写");
        }
        #endregion

        #region SDE直连方式加载
        private void btnAddSDEByDirect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没做SDE数据库，这个功能就没写");
        }
        #endregion

        #endregion

        #region 文本及Excel数据转shp数据加载
        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            FrmAddTxt frmAddTxt = new FrmAddTxt(mainMapControl);
            frmAddTxt.Show();
        }
        #endregion

        #endregion

        #region 保存地图文档
        #region 直接保存
        private void btnSaveMap_Click(object sender, EventArgs e)
        {
            SaveMxdHelper saveMxdHelper = new SaveMxdHelper();
            saveMxdHelper.SaveMap(mainMapControl);
        }
        #endregion

        #region 另存为
        private void btnSaveAsMap_Click(object sender, EventArgs e)
        {
            SaveMxdHelper saveMxdHelper = new SaveMxdHelper();
            saveMxdHelper.SaveAsMap(mainMapControl);
        }
        #endregion

        #endregion

        #region 地图浏览
        #region 选框放大
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            toolRunControl = viewControlHelper.ViewZoomIn(mainMapControl);
        }
        #endregion

        #region 选框缩小
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            toolRunControl = viewControlHelper.ViewZoomOut(mainMapControl);
        }
        #endregion

        #region 固定比例放大
        private void btnZoomInStep_Click(object sender, EventArgs e)
        {
            viewControlHelper.ViewZoomInStep(mainMapControl);
        }
        #endregion

        #region 固定比例缩小
        private void btnZoomOutStep_Click(object sender, EventArgs e)
        {
            viewControlHelper.ViewZoomOutStep(mainMapControl);
        }
        #endregion

        #region 地图漫游
        private void btnPan_Click(object sender, EventArgs e)
        {
            toolRunControl = viewControlHelper.ViewPan(mainMapControl);
        }
        #endregion

        #region 前一视图
        private void btnFrontView_Click(object sender, EventArgs e)
        {
            viewControlHelper.FrontView(mainMapControl, btnForWardView, btnFrontView);
        }
        #endregion

        #region 后一视图
        private void btnForWardView_Click(object sender, EventArgs e)
        {
            viewControlHelper.ForwardView(mainMapControl, btnFrontView, btnForWardView);
        }
        #endregion

        #region 地图全图
        private void btnFullView_Click(object sender, EventArgs e)
        {
            mainMapControl.Extent = mainMapControl.FullExtent;
        }
        #endregion
        #endregion

        #region 地图控件操作事件
        #region 鼠标按下事件
        private void mainMapControl_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (toolRunControl != null)
            {
                toolRunControl.OnMouseDownRun();
            }
        }
        #endregion

        #region 鼠标移动事件
        private void mainMapControl_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (toolRunControl != null)
            {
                toolRunControl.OnMouseMoveRun();
            }
        }
        #endregion

        #region 鼠标抬起事件
        private void mainMapControl_OnMouseUp(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseUpEvent e)
        {
            if (toolRunControl != null)
            {
                toolRunControl.OnMouseUpRun();
            }
        }
        #endregion
        #endregion
    }
}
