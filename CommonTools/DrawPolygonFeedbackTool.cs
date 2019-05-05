using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    /// <summary>
    /// 面积反馈工具
    /// </summary>
    public class DrawPolygonFeedbackTool : IToolRunControl, IToolGetResult
    {
        private double totalArea = 0;
        private IPointCollection pointCollection = new MultipointClass();
        private INewPolygonFeedback polygonFeedback;
        private AxMapControl mapControl;
        /// <summary>
        /// 实例化对象
        /// </summary>
        /// <param name="polygonFeedback">面反馈接口</param>
        /// <param name="mapControl">要绑定的控件</param>
        public DrawPolygonFeedbackTool(INewPolygonFeedback polygonFeedback, AxMapControl mapControl)
        {
            this.polygonFeedback = polygonFeedback;
            this.mapControl = mapControl;
        }
        /// <summary>
        /// 获得测量结果
        /// </summary>
        /// <param name="unit">单位</param>
        /// <returns>结果</returns>
        public string GetResult(string unit)
        {
            return String.Format("总面积为：{0:#.###}平方{1}", totalArea,  unit);
        }
        /// <summary>
        /// 双击时运行
        /// </summary>
        public void OnDoubleClickRun()
        {
            pointCollection.RemovePoints(0, pointCollection.PointCount);
            polygonFeedback.Stop();
            polygonFeedback = null;
        }
        /// <summary>
        /// 单机时运行
        /// </summary>
        /// <param name="clickPT">单机的地图点</param>
        public void OnMouseDownRun(IPoint clickPT)
        {
            if (polygonFeedback == null)
            {
                polygonFeedback = new NewPolygonFeedbackClass();
                polygonFeedback.Display = (mapControl.Map as IActiveView).ScreenDisplay;
                pointCollection.RemovePoints(0, pointCollection.PointCount);
                polygonFeedback.Start(clickPT);
                pointCollection.AddPoint(clickPT, Type.Missing, Type.Missing);
            }
            else
            {
                polygonFeedback.AddPoint(clickPT);
                pointCollection.AddPoint(clickPT, Type.Missing, Type.Missing);
            }
        }
        /// <summary>
        /// 鼠标移动时运行
        /// </summary>
        /// <param name="movePT">鼠标地图点</param>
        public void OnMouseMoveRun(IPoint movePT)
        {
            if (polygonFeedback != null)
            {
                polygonFeedback.MoveTo(movePT);
            }
            // 点集合
            IPointCollection pointColTemp = new Polygon();
            for (int i = 0; i < pointCollection.PointCount; i++)
            {
                pointColTemp.AddPoint(pointCollection.get_Point(i), Type.Missing, Type.Missing);
            }
            // 添加当前点
            pointColTemp.AddPoint(movePT);
            if (pointColTemp.PointCount < 3) return;
            // 获得图形
            IPolygon polygon = pointColTemp as IPolygon;
            if (polygon != null)
            {
                polygon.Close();
                IGeometry geo = polygon as IGeometry;
                ITopologicalOperator topo = geo as ITopologicalOperator;
                topo.Simplify();
                geo.Project(mapControl.SpatialReference);
                // 获得面积
                IArea area = geo as IArea;
                totalArea = area.Area;
            }
        }

        public void OnMouseUpRun()
        {
        }
    }
}
