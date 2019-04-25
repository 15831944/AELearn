using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFile
{
    /// <summary>
    /// 添加shp文件
    /// </summary>
    public class AddShpHelper
    {
        /// <summary>
        /// 添加shp文件
        /// </summary>
        /// <param name="mapControl">要添加文件的地图控件</param>
        public void AddShpFile(AxMapControl mapControl)
        {
            //获取文件路径
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "加载shp文件";
            openFileDialog.Filter = "矢量文件(*.shp)|*.shp";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            //文件路径和文件名
            string fullPath = openFileDialog.FileName;
            int subIndex = fullPath.LastIndexOf("\\");
            string filePath = fullPath.Substring(0, subIndex);
            string fileName = fullPath.Substring(subIndex + 1);
            //获取数据集
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(filePath, 0);
            IFeatureLayer featureLayer = new FeatureLayer();
            featureLayer.FeatureClass = featureWorkspace.OpenFeatureClass(fileName);
            featureLayer.Name = featureLayer.FeatureClass.AliasName;
            //添加数据
            mapControl.Map.AddLayer(featureLayer);
            mapControl.ActiveView.Refresh();

            //mapControl.AddShapeFile(filePath, fileName);    //控件自带的方法
        }
    }
}
