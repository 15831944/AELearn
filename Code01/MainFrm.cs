using AddFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code01
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

        private void btnAddCADByLayer_Click(object sender, EventArgs e)
        {

        }
    }
}
