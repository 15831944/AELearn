using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Model;
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
    /// 文本地理坐标文件加载
    /// </summary>
    public class AddTxtHelper
    {
        /// <summary>
        /// 文本地理坐标文件加载
        /// </summary>
        /// <param name="mapControl">要加载的地图控件</param>
        /// <param name="InputTxt">要加载的地图控件</param>
        /// <param name="OutputShp">要加载的地图控件</param>
        public void AddTxt(AxMapControl mapControl, string InputTxt, string OutputShp)
        {
            List<string> columns = new List<string>();
            char[] splChar = new char[] { ',', ' ', '\t' };
            // 1.将文本文件转换为CPoint集合
            List<CPoint> pointList = new List<CPoint>();
            FileStream fileStream = new FileStream(InputTxt, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
            string strLine = streamReader.ReadLine();
            if (strLine != null)
            {
                string[] strArray = strLine.Split(splChar);
                if (strArray.Length > 0)
                {
                    foreach (string item in strArray)
                    {
                        columns.Add(item);
                    }
                }
                while ((strLine = streamReader.ReadLine()) != null)
                {
                    strArray = strLine.Split(splChar);
                    CPoint cPoint = new CPoint();
                    cPoint.Name = strArray[0];
                    cPoint.x = Convert.ToDouble(strArray[1]);
                    cPoint.y = Convert.ToDouble(strArray[2]);
                    pointList.Add(cPoint);
                }
            }
            streamReader.Close();
            // 2.将CPoint集合转换为FeatureClass
            if (pointList.Count > 0)
            {
                int splIndex = OutputShp.LastIndexOf("\\");
                string filePath = OutputShp.Substring(0, splIndex);
                string fileName = OutputShp.Substring(splIndex + 1);
                //字段集
                IFields fields = new FieldsClass();
                IFieldsEdit fieldsEdit = (IFieldsEdit)fields;
                //单个字段
                IField field = new FieldClass();
                IFieldEdit fieldEdit = (IFieldEdit)field;
                //几何定义
                IGeometryDef geometryDef = new GeometryDefClass();
                IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;

                //赋值-几何定义
                ISpatialReferenceFactory spatialReferenceFactory = new SpatialReferenceEnvironmentClass();
                ISpatialReference spatialReference = spatialReferenceFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_Beijing1954);
                geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
                geometryDefEdit.SpatialReference_2 = spatialReference;
                //赋值-字段
                fieldEdit.Name_2 = "Shape";
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
                fieldEdit.GeometryDef_2 = geometryDef;
                //赋值-字段集和
                fieldsEdit.AddField(field);

                //再来一遍
                field = new FieldClass();
                fieldEdit = (IFieldEdit)field;

                fieldEdit.Name_2 = "Test";
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;

                fieldsEdit.AddField(field);

                //创建图层
                IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
                IFeatureWorkspace workspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(filePath, 0);
                IFeatureClass featureClass = workspace.CreateFeatureClass(fileName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
                //添加图斑
                IPoint point = new PointClass();
                foreach (CPoint item in pointList)
                {
                    point.X = item.x;
                    point.Y = item.y;
                    IFeature feature = featureClass.CreateFeature();
                    feature.Shape = point;
                    feature.Store();
                }
                // 3.将FeatureClass加入控件
                IFeatureLayer featureLayer = new FeatureLayerClass();
                featureLayer.FeatureClass = featureClass;
                featureLayer.Name = featureClass.AliasName;
                mapControl.AddLayer(featureLayer);
            }
        }
    }
}
