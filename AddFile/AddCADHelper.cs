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
    /// 添加CAD数据
    /// </summary>
    public class AddCADHelper
    {
        #region 以矢量的方式加载CAD数据
        /// <summary>
        /// 以矢量的方式加载CAD数据
        /// </summary>
        /// <param name="mapControl">要加载的地图控件</param>
        public void AddCADByShp(AxMapControl mapControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CAD(*.dwg)|*.dwg";
            openFileDialog.Title = "打开CAD数据文件";
            openFileDialog.ShowDialog();

            string fullPath = openFileDialog.FileName;
            if (fullPath == "") return;
            //获取文件名和文件路径
            int SubIndex = fullPath.LastIndexOf("\\");
            string fileDir = fullPath.Substring(0, SubIndex);
            string fileName = fullPath.Substring(SubIndex + 1);

            IWorkspaceFactory workspaceFactory = new CadWorkspaceFactory();
            IFeatureWorkspace workspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(fileDir, 0);
            IFeatureClass feature = workspace.OpenFeatureClass(fileName + ":polygon");
            IFeatureLayer featureLayer = new FeatureLayer();
            featureLayer.FeatureClass = feature;
            featureLayer.Name = fileName;

            mapControl.AddLayer(featureLayer);
            mapControl.ActiveView.Refresh();
        }
        #endregion

        #region 整体添加CAD数据
        /// <summary>
        /// 整体添加CAD数据
        /// </summary>
        /// <param name="mapControl">要添加的地图控件</param>
        public void AddWholeCAD(AxMapControl mapControl)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CAD(*.dwg)|*.dwg";
            openFileDialog.Title = "打开CAD数据文件";
            openFileDialog.ShowDialog();

            string fullPath = openFileDialog.FileName;
            if (fullPath == "") return;
            //获取文件名和文件路径
            int SubIndex = fullPath.LastIndexOf("\\");
            string fileDir = fullPath.Substring(0, SubIndex);
            string fileName = fullPath.Substring(SubIndex + 1);

            IWorkspaceFactory workspaceFactory = new CadWorkspaceFactory();
            IFeatureWorkspace workspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(fileDir, 0);
            IFeatureDataset FeatureDataset = workspace.OpenFeatureDataset(fileName);
            IFeatureClassContainer featureClassContainer = FeatureDataset as IFeatureClassContainer;
            IFeatureClass featureClass;
            IFeatureLayer featureLayer;
            for (int i = 0; i < featureClassContainer.ClassCount; i++)
            {
                featureClass = featureClassContainer.get_Class(i);
                if (featureClass.FeatureType == esriFeatureType.esriFTCoverageAnnotation)
                {
                    featureLayer = new CadAnnotationLayerClass();
                    featureLayer.FeatureClass = featureClass;
                    featureLayer.Name = featureClass.AliasName;
                    mapControl.AddLayer(featureLayer);
                }
                else
                {
                    featureLayer = new FeatureLayerClass();
                    featureLayer.FeatureClass = featureClass;
                    featureLayer.Name = featureClass.AliasName;
                    mapControl.AddLayer(featureLayer);
                }
                mapControl.ActiveView.Refresh();
            }
        }
        #endregion

        #region 以栅格背景图的形式添加CAD数据
        /// <summary>
        /// 以栅格背景图的形式添加CAD数据
        /// </summary>
        /// <param name="mapControl">要添加CAD数据的地图控件</param>
        public void AddCADByRaster(AxMapControl mapControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CAD(*.dwg)|*.dwg";
            openFileDialog.Title = "打开CAD数据文件";
            openFileDialog.ShowDialog();

            string fullPath = openFileDialog.FileName;
            if (fullPath == "") return;
            //获取文件名和文件路径
            int subIndex = fullPath.LastIndexOf("\\");
            string fileDir = fullPath.Substring(0, subIndex);
            string fileName = fullPath.Substring(subIndex + 1);

            IWorkspaceFactory CadWorkspaceFactory = new CadWorkspaceFactory();
            ICadDrawingWorkspace CadWorkspace = (ICadDrawingWorkspace)CadWorkspaceFactory.OpenFromFile(fileDir, 0);
            ICadDrawingDataset cadDrawingDataset = CadWorkspace.OpenCadDrawingDataset(fileName);
            ICadLayer cadLayer = new CadLayerClass();
            cadLayer.CadDrawingDataset = cadDrawingDataset;
            mapControl.AddLayer(cadLayer);
            mapControl.ActiveView.Refresh();
        } 
        #endregion
    }
}
