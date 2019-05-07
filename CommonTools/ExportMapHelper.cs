using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    /// <summary>
    /// 帮助导出地图
    /// </summary>
    public class ExportMapHelper
    {
        /// <summary>
        /// 创建图形元素
        /// </summary>
        /// <param name="geometry">几何图形</param>
        /// <param name="lineColor">边界颜色</param>
        /// <param name="fillColor">填充颜色</param>
        /// <returns>图形元素</returns>
        public static IElement CreateElement(IGeometry geometry, IRgbColor lineColor, IRgbColor fillColor)
        {
            if (geometry == null || lineColor == null || fillColor == null) return null;
            IElement element = null;
            // 判断图形的类型
            if (geometry is IEnvelope) element = new RectangleElementClass();
            else if (geometry is IPolygon) element = new PolygonElementClass();
            else if (geometry is ICircularArc)
            {
                ISegment segment = geometry as ISegment;
                ISegmentCollection segmentCollection = new PolygonClass();
                segmentCollection.AddSegment(segment, Type.Missing, Type.Missing);
                IPolygon polygon = segmentCollection as IPolygon;
                geometry = polygon as IGeometry;
                element = new CircleElementClass();
            }
            else if (geometry is IPolyline) element = new LineElementClass();

            if (element == null) return null;

            element.Geometry = geometry;
            ISimpleFillSymbol symbol = new SimpleFillSymbolClass();
            symbol.Outline.Color = lineColor;
            symbol.Color = fillColor;
            symbol.Style = esriSimpleFillStyle.esriSFSCross;
            if (symbol == null) return null;
            IFillShapeElement fillShapeElement = element as IFillShapeElement;
            fillShapeElement.Symbol = symbol;

            return element;
        }

        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <param name="R">红</param>
        /// <param name="G">绿</param>
        /// <param name="B">蓝</param>
        /// <returns>颜色对象</returns>
        public static IRgbColor GetRgbColor(int R = 0, int G = 0, int B = 0)
        {
            if (R < 0 || R > 255 || G < 0 || G > 255 || B < 0 || B > 255) return null;
            IRgbColor color = new RgbColorClass();
            color.Red = R;
            color.Green = G;
            color.Blue = B;
            return color;
        }

        /// <summary>
        /// 视图中绘制几何元素
        /// </summary>
        /// <param name="geometry">几何图形</param>
        /// <param name="activeView">视图</param>
        public static void AddElement(IGeometry geometry, IActiveView activeView)
        {
            IElement element = CreateElement(geometry, GetRgbColor(), GetRgbColor(204, 175, 235));
            IGraphicsContainer graphicsContainer = activeView.GraphicsContainer;
            if (graphicsContainer != null)
            {
                graphicsContainer.AddElement(element, 0);
                activeView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, element, null);
            }
        }

    }
}
