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
    /// 画线反馈工具
    /// </summary>
    public class DrawLineFeedbackTool : IToolRunControl,IToolGetResult
    {
        private double currentLength;
        private double totalLength;
        private double lengthResult = 0;
        private IPoint tempPT;
        private INewLineFeedback lineFeedback;
        private AxMapControl mapControl;
        /// <summary>
        /// 实例线反馈工具
        /// </summary>
        /// <param name="lineFeedback">线反馈工具</param>
        /// <param name="mapControl">绑定的地图控件</param>
        public DrawLineFeedbackTool(INewLineFeedback lineFeedback,AxMapControl mapControl)
        {
            this.lineFeedback = lineFeedback;
            this.mapControl = mapControl;
        }
        /// <summary>
        /// 鼠标落下时运行
        /// </summary>
        /// <param name="clickPT">地图点</param>
        public void OnMouseDownRun(IPoint clickPT)
        {
            if (lineFeedback == null)
            {
                lineFeedback = new NewLineFeedbackClass();
                lineFeedback.Display = (mapControl.Map as IActiveView).ScreenDisplay;
                lineFeedback.Start(clickPT);
                // 长度计算
                currentLength = 0;
                totalLength = 0;
            }
            else
            {
                lineFeedback.AddPoint(clickPT);
                // 长度计算
                totalLength += Math.Round(Math.Sqrt(Math.Pow(tempPT.X - clickPT.X, 2) + Math.Pow(tempPT.Y - clickPT.Y, 2)), 3);
                
            }
            tempPT = clickPT;
        }
        /// <summary>
        /// 鼠标移动时运行
        /// </summary>
        /// <param name="movePT">地图点</param>
        public void OnMouseMoveRun(IPoint movePT)
        {
            if (lineFeedback != null)
            {
                lineFeedback.MoveTo(movePT);
                currentLength = Math.Round(Math.Sqrt(Math.Pow(tempPT.X - movePT.X, 2) + Math.Pow(tempPT.Y - movePT.Y, 2)), 3);
                lengthResult = totalLength + currentLength;
            }
        }

        public void OnMouseUpRun()
        {
        }
        /// <summary>
        /// 鼠标双击时运行
        /// </summary>
        public void OnDoubleClickRun()
        {
            lineFeedback.Stop();
            lineFeedback = null;
        }
        /// <summary>
        /// 得到测量结果
        /// </summary>
        /// <param name="unit">单位</param>
        /// <returns>结果</returns>
        public string GetResult(string unit)
        {
            return String.Format("当前距离为：{0}{2}\n总距离为：{1}{2}", currentLength, lengthResult,unit);
        }
    }
}
