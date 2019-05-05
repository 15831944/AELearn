using ESRI.ArcGIS.Controls;
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
    /// 地图漫游工具
    /// </summary>
    public class ViewPanTool : IToolRunControl
    {
        /// <summary>
        /// 实例化工具
        /// </summary>
        /// <param name="mapControl">要绑定的地图控件</param>
        public ViewPanTool(AxMapControl mapControl)
        {
            this.MapControl = mapControl;
        }
        /// <summary>
        /// 绑定的地图控件
        /// </summary>
        public AxMapControl MapControl { get; set; }
        /// <summary>
        /// 鼠标按下时运行
        /// </summary>
        /// <param name="clickPT">地图点</param>
        public void OnMouseDownRun(IPoint clickPT)
        {
            MapControl.Pan();
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
        /// <summary>
        /// 鼠标按钮双击时运行
        /// </summary>
        public void OnDoubleClickRun()
        {
        }
    }
}
