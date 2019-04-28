using CommonTools;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapViewControl
{
    /// <summary>
    /// 地图浏览操作
    /// </summary>
    public class ViewControlHelper
    {
        #region 逐级放大
        /// <summary>
        /// 等比例放大
        /// </summary>
        /// <param name="mapControl">要操作的地图控件</param>
        public void ViewZoomInStep(AxMapControl mapControl)
        {
            IEnvelope envelope = mapControl.Extent;
            envelope.Expand(0.5, 0.5, true);
            mapControl.Extent = envelope;
            mapControl.ActiveView.Refresh();
        }
        #endregion

        #region 逐级缩小
        /// <summary>
        /// 等比例缩小
        /// </summary>
        /// <param name="mapControl">要操作的地图控件</param>
        public void ViewZoomOutStep(AxMapControl mapControl)
        {
            IActiveView activeView = mapControl.ActiveView;
            IEnvelope envelope = activeView.Extent;
            IPoint centerPoint = new PointClass();
            centerPoint.PutCoords((envelope.XMin + envelope.XMax) / 2, (envelope.YMin + envelope.YMax) / 2);
            envelope.Expand(1.5, 1.5, true);
            envelope.CenterAt(centerPoint);
            activeView.Extent = envelope;
            activeView.Refresh();
        }
        #endregion

        #region 拉框放大
        /// <summary>
        /// 拉框放大
        /// </summary>
        /// <param name="mapControl">要控制的地图控件</param>
        /// <returns>拉框放大工具</returns>
        public IToolRunControl ViewZoomIn(AxMapControl mapControl)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerZoomIn;
            return new ViewZoomInTool(mapControl);
        }
        #endregion

        #region 拉框缩小
        /// <summary>
        /// 拉框缩小
        /// </summary>
        /// <param name="mapControl">要控制的地图控件</param>
        /// <returns>拉框缩小工具</returns>
        public IToolRunControl ViewZoomOut(AxMapControl mapControl)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerZoomOut;
            return new ViewZoomOutTool(mapControl);
        }
        #endregion

        #region 地图漫游
        /// <summary>
        /// 地图漫游
        /// </summary>
        /// <param name="mapControl">要操作的地图控件</param>
        /// <returns>地图漫游工具</returns>
        public IToolRunControl ViewPan(AxMapControl mapControl)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerPan;
            return new ViewPanTool(mapControl);
        }
        #endregion

        #region 前一视图
        /// <summary>
        /// 前一视图
        /// </summary>
        /// <param name="mapControl">要操作的地图控件</param>
        /// <param name="btnForwardView">后一视图按钮</param>
        /// <param name="btnFrontView">前一视图按钮</param>
        public void FrontView(AxMapControl mapControl, ToolStripMenuItem btnForwardView, ToolStripMenuItem btnFrontView)
        {
            IExtentStack stack = mapControl.ActiveView.ExtentStack;
            if (stack.CanUndo())
            {
                stack.Undo();
                btnForwardView.Enabled = true;
                if (!stack.CanUndo())
                {
                    btnFrontView.Enabled = false;
                }
            }
            mapControl.ActiveView.Refresh();
        }
        #endregion

        #region 后一视图
        /// <summary>
        /// 后一视图
        /// </summary>
        /// <param name="mapControl">要操作的地图控件</param>
        /// <param name="btnFrontView">前一视图按钮</param>
        /// <param name="btnForwardView">后一视图按钮</param>
        public void ForwardView(AxMapControl mapControl, ToolStripMenuItem btnFrontView, ToolStripMenuItem btnForwardView)
        {
            IExtentStack stack = mapControl.ActiveView.ExtentStack;
            if (stack.CanRedo())
            {
                stack.Redo();
                btnFrontView.Enabled = true;
                if (!stack.CanRedo())
                {
                    btnForwardView.Enabled = false;
                }
            }
            mapControl.ActiveView.Refresh();
        } 
        #endregion
    }
}
