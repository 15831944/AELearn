using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 视图鼠标控制接口
    /// </summary>
    public interface IToolRunControl
    {
        /// <summary>
        /// 鼠标按下时运行
        /// </summary>
        /// <param name="clickPT">地图点</param>
        void OnMouseDownRun(IPoint clickPT);
        /// <summary>
        /// 抬起鼠标时运行
        /// </summary>
        void OnMouseUpRun();
        /// <summary>
        /// 鼠标移动时运行
        /// </summary>
        /// <param name="movePT">地图点</param>
        void OnMouseMoveRun(IPoint movePT);
        /// <summary>
        /// 鼠标双击时运行
        /// </summary>
        void OnDoubleClickRun();
    }
}
