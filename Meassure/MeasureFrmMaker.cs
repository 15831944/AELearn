using ESRI.ArcGIS.Controls;
using MapOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meassure
{
    /// <summary>
    /// 创建测量窗口
    /// </summary>
    public class MeasureFrmMaker
    {
        private AxMapControl mapControl;
        /// <summary>
        /// 实例测量窗口制造者
        /// </summary>
        /// <param name="mapControl">绑定的地图控件</param>
        public MeasureFrmMaker(AxMapControl mapControl)
        {
            this.mapControl = mapControl;
        }

        public void GetMeasureFrm(ref FrmMeasureResult frmMeasureResult)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerCrosshair;
            // 单例实例窗口，如果存在则调到最前端
            if (frmMeasureResult == null || frmMeasureResult.IsDisposed)
            {

            }
            else
            {

            }
        }
    }
}
