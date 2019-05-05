using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class SelectFeatureTool : IToolRunControl
    {
        private IMapControlEvents2_OnMouseDownEvent e = null;
        private AxMapControl mapControl;
        public SelectFeatureTool(AxMapControl mapControl)
        {
            this.mapControl = mapControl;
        }

        public void OnDoubleClickRun()
        {
        }

        public void OnMouseDownRun(IPoint clickPT)
        {
            IEnvelope envelope = mapControl.TrackRectangle();
            if (envelope.IsEmpty)
            {
                if (e == null) return;
                tagRECT rect;
                rect.top = e.y - 5;
                rect.bottom = e.y + 5;
                rect.left = e.x - 5;
                rect.right = e.x + 5;
                mapControl.ActiveView.ScreenDisplay.DisplayTransformation.TransformRect(envelope, ref rect, 4);
                envelope.SpatialReference = mapControl.ActiveView.FocusMap.SpatialReference;
            }
            IGeometry geometry = envelope as IGeometry;
            mapControl.Map.SelectByShape(geometry, null, false);
            mapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);

        }

        public void OnMouseMoveRun(IPoint movePT)
        {
        }

        public void OnMouseUpRun()
        {
        }
        /// <summary>
        /// 迫不得已，造了一个传参的方法，因为不想大改，设计失误了
        /// </summary>
        /// <param name="e">要传的参数</param>
        public void GetEventArgs(IMapControlEvents2_OnMouseDownEvent e)
        {
            this.e = e;
        }
    }
}
