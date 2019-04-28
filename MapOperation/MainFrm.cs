using AddFile;
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
        #endregion

        #region 初始化
        public MainFrm()
        {
            InitializeComponent();
            addMxdHelper = new AddMxdHelper();
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
    }
}
