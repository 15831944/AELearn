using ESRI.ArcGIS.Controls;
using MapOperation;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MapOperation.FrmMeasureResult;

namespace MapOperation
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
        /// <summary>
        /// 得到测量窗口
        /// </summary>
        /// <param name="enumMeasureType">测量类型</param>
        /// <param name="frmMeasureResult">窗口</param>
        public void GetMeasureFrm(EnumMeasureOperation enumMeasureType,ref FrmMeasureResult frmMeasureResult)
        {
            IToolRunControl tool;
            mapControl.MousePointer = esriControlsMousePointer.esriPointerCrosshair;
            // 单例实例窗口，如果存在则调到最前端
            if (frmMeasureResult == null || frmMeasureResult.IsDisposed)
            {
                frmMeasureResult = new FrmMeasureResult();
                frmMeasureResult.lblMeasureResult.Text = "";
                string frmName = string.Empty;
                switch (enumMeasureType)
                {
                    case EnumMeasureOperation.lengthMeasure:
                        frmName = "距离测量";
                        break;
                    case EnumMeasureOperation.areaMeasure:
                        frmName = "面积测量";
                        break;
                    default:
                        frmName = "未知错误";
                        break;
                }
                frmMeasureResult.Text = frmName;
            }
            else
            {
                frmMeasureResult.Activate();
            }
        }
    }
}
