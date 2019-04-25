using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFile
{
    /// <summary>
    /// 栅格数据添加
    /// </summary>
    public class AddRasterHelper
    {
        /// <summary>
        /// 添加栅格数据
        /// </summary>
        /// <param name="mapControl">要添加栅格数据的地图控件</param>
        public void AddRasterFile(AxMapControl mapControl)
        {
            //获得文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开Raster文件";
            openFileDialog.Filter = "栅格文件 (*.*)|*.bmp;*.tif;*.jpg;*.img|(*.bmp)|*.bmp|(*.tif)|*.tif|(*.jpg)|*.jpg|(*.img)|*.img";
            openFileDialog.CheckFileExists = true;
            openFileDialog.ShowDialog();
            //拆分路径和文件名
            string fullPath = openFileDialog.FileName;
            if (fullPath == "") return;
            string fileDir = Path.GetDirectoryName(fullPath);
            string fileName = Path.GetFileName(fullPath);
            //从工作空间拿数据集
            IWorkspaceFactory workspaceFactory = new RasterWorkspaceFactory();
            IRasterWorkspace rasterWorkspace = (IRasterWorkspace)workspaceFactory.OpenFromFile(fileDir, 0);
            IRasterDataset rasterDataset = rasterWorkspace.OpenRasterDataset(fileName);
            //栅格金字塔
            IRasterPyramid3 rasPyramid = rasterDataset as IRasterPyramid3;
            if (rasPyramid != null)
            {
                if (!rasPyramid.Present)
                {
                    rasPyramid.Create();
                }
            }
            //从数据集拿数据
            IRaster raster = rasterDataset.CreateDefaultRaster();
            IRasterLayer rasterLayer = new RasterLayerClass();
            rasterLayer.CreateFromRaster(raster);
            //加载数据
            mapControl.AddLayer(rasterLayer);
            mapControl.ActiveView.Refresh();
        }
    }
}
