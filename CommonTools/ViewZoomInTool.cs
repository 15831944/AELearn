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
    /// 视图拉框放大工具
    /// </summary>
    public class ViewZoomInTool : IToolRunControl
    {
        /// <summary>
        /// 实例化工具
        /// </summary>
        /// <param name="mapControl">绑定的地图控件</param>
        public ViewZoomInTool(AxMapControl mapControl)
        {
            this.MapControl = mapControl;
        }
        /// <summary>
        /// 绑定的地图控件
        /// </summary>
        public AxMapControl MapControl { get; set; }
        /// <summary>
        /// 鼠标按钮落下时运行
        /// </summary>
        public void OnMouseDownRun()
        {
            IEnvelope envelope = MapControl.TrackRectangle();
            if (envelope == null || envelope.IsEmpty || envelope.Width == 0 || envelope.Height == 0) return;
            MapControl.Extent = envelope;
            MapControl.ActiveView.Refresh();
        }
        /// <summary>
        /// 鼠标移动时运行
        /// </summary>
        public void OnMouseMoveRun()
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
