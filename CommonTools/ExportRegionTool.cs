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
    public class ExportRegionTool : IToolRunControl
    {
        private AxMapControl mapControl;
        public ExportRegionTool(AxMapControl mapControl)
        {
            this.mapControl = mapControl;
        }

        public void OnDoubleClickRun()
        {
        }

        public void OnMouseDownRun(IPoint clickPT)
        {
            mapControl.ActiveView.GraphicsContainer.DeleteAllElements();
            mapControl.ActiveView.Refresh();
            IPolygon polygon = DrawPolygon(mapControl);
            if (polygon == null) return;
            ExportMapHelper.AddElement(polygon, mapControl.ActiveView);
        }

        public void OnMouseMoveRun(IPoint movePT)
        {
        }

        public void OnMouseUpRun()
        {
        }

        /// <summary>
        /// 画多边形
        /// </summary>
        /// <param name="mapControl">绑定的地图控件</param>
        /// <returns>多边形</returns>
        public IPolygon DrawPolygon(AxMapControl mapControl)
        {
            if (mapControl == null) return null;
            IRubberBand rubberBand = new RubberPolygonClass();
            return (IPolygon)rubberBand.TrackNew(mapControl.ActiveView.ScreenDisplay, null);
        }
    }
}
