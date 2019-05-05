using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools
{
    /// <summary>
    /// 视图缩小工具
    /// </summary>
    public class ViewZoomOutTool : IToolRunControl
    {
        /// <summary>
        /// 实例化工具
        /// </summary>
        /// <param name="mapControl">绑定的地图控件</param>
        public ViewZoomOutTool(AxMapControl mapControl)
        {
            this.MapControl = mapControl;
        }
        /// <summary>
        /// 绑定的地图控件
        /// </summary>
        public AxMapControl MapControl { get; set; }

        /// <summary>
        /// 鼠标双击时运行
        /// </summary>
        public void OnDoubleClickRun()
        {
        }

        /// <summary>
        /// 鼠标按下时运行
        /// </summary>
        /// <param name="clickPT">地图点</param>
        public void OnMouseDownRun(IPoint clickPT)
        {
            IEnvelope envelope = MapControl.TrackRectangle();
            if (envelope == null || envelope.IsEmpty || envelope.Width == 0 || envelope.Height == 0) return;
            double dWidth = MapControl.Extent.Width * MapControl.Extent.Width / envelope.Width;
            double dHeight = MapControl.Extent.Height * MapControl.Extent.Height / envelope.Height;
            double dXmin = MapControl.Extent.XMin -
                           ((envelope.XMin - MapControl.Extent.XMin) * MapControl.Extent.Width /
                            envelope.Width);
            double dYmin = MapControl.Extent.YMin -
                           ((envelope.YMin - MapControl.Extent.YMin) * MapControl.Extent.Height /
                            envelope.Height);
            double dXmax = dXmin + dWidth;
            double dYmax = dYmin + dHeight;
            envelope.PutCoords(dXmin, dYmin, dXmax, dYmax);
            MapControl.Extent = envelope;
            MapControl.ActiveView.Refresh();
        }
        /// <summary>
        /// 鼠标移动时运行
        /// </summary>
        /// <param name="movePT">地图点</param>
        public void OnMouseMoveRun(IPoint movePT)
        {
        }
        /// <summary>
        /// 鼠标按钮抬起时运行
        /// </summary>
        public void OnMouseUpRun()
        {
        }
    }
}
