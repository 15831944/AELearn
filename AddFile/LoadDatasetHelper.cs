using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFile
{
    /// <summary>
    /// 读取数据集
    /// </summary>
    class LoadDatasetHelper
    {
        #region 加载数据集
        /// <summary>
        /// 加载数据集
        /// </summary>
        /// <param name="workspace">数据集所在工作空间</param>
        /// <param name="mapControl">要加载的地图控件</param>
        public void AddAllDataset(IWorkspace workspace, AxMapControl mapControl)
        {
            IEnumDataset enumDataset = workspace.get_Datasets(esriDatasetType.esriDTAny);
            enumDataset.Reset();
            IDataset dataset;
            while ((dataset = enumDataset.Next()) != null)
            {
                if (dataset is IFeatureDataset)     //要素数据集
                {
                    IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
                    IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset(dataset.Name);
                    IEnumDataset enumDatasetSub = featureDataset.Subsets;
                    enumDatasetSub.Reset();
                    IDataset datasetSub;
                    while ((datasetSub = enumDatasetSub.Next()) != null)
                    {
                        if (datasetSub is FeatureClass)
                        {
                            IFeatureLayer featureLayer = new FeatureLayerClass();
                            featureLayer.FeatureClass = featureWorkspace.OpenFeatureClass(datasetSub.Name);
                            if (featureLayer.FeatureClass != null)
                            {
                                featureLayer.Name = featureLayer.FeatureClass.AliasName;
                                mapControl.AddLayer(featureLayer);
                            }
                        }
                    }
                }
                else if (dataset is IFeatureClass)  //要素类
                {
                    IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
                    IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(dataset.Name);
                    IFeatureLayer featureLayer = new FeatureLayerClass();
                    featureLayer.FeatureClass = featureClass;
                    featureLayer.Name = featureClass.AliasName;
                    mapControl.AddLayer(featureLayer);

                }
                else if (dataset is IRasterDataset) //栅格数据集
                {
                    IRasterWorkspaceEx rasterWorkspace = (IRasterWorkspaceEx)workspace;
                    IRasterDataset rasterDataset = rasterWorkspace.OpenRasterDataset(dataset.Name);
                    IRasterPyramid3 rasPyramid = rasterDataset as IRasterPyramid3;
                    if (rasPyramid != null)
                    {
                        if (!rasPyramid.Present)
                        {
                            rasPyramid.Create();
                        }
                    }
                    IRasterLayer rasterLayer = new RasterLayerClass();
                    rasterLayer.CreateFromDataset(rasterDataset);
                    ILayer layer = rasterLayer as ILayer;
                    mapControl.AddLayer(layer, 0);
                }
            }
            mapControl.ActiveView.Refresh();
        } 
        #endregion
    }
}
