using ESRI.ArcGIS.esriSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    /// <summary>
    /// 获取地图单位
    /// </summary>
    public class MapUnitHelper
    {
        private esriUnits esriUnits;
        /// <summary>
        /// 构造单位获取器
        /// </summary>
        /// <param name="esriUnits">单位类型</param>
        public MapUnitHelper(esriUnits esriUnits)
        {
            this.esriUnits = esriUnits;
        }
        /// <summary>
        /// 获取中文单位的字符串
        /// </summary>
        /// <returns>单位字符串中文</returns>
        public string GetMapUnitString()
        {
            string mapUnit = string.Empty;
            switch (esriUnits)
            {
                case esriUnits.esriUnknownUnits:
                    mapUnit = "未知单位";
                    break;
                case esriUnits.esriInches:
                    mapUnit = "英寸";
                    break;
                case esriUnits.esriPoints:
                    mapUnit = "点";
                    break;
                case esriUnits.esriFeet:
                    mapUnit = "尺";
                    break;
                case esriUnits.esriYards:
                    mapUnit = "码";
                    break;
                case esriUnits.esriMiles:
                    mapUnit = "英里";
                    break;
                case esriUnits.esriNauticalMiles:
                    mapUnit = "海里";
                    break;
                case esriUnits.esriMillimeters:
                    mapUnit = "毫米";
                    break;
                case esriUnits.esriCentimeters:
                    mapUnit = "厘米";
                    break;
                case esriUnits.esriMeters:
                    mapUnit = "米";
                    break;
                case esriUnits.esriKilometers:
                    mapUnit = "千米";
                    break;
                case esriUnits.esriDecimalDegrees:
                    mapUnit = "十进制";
                    break;
                case esriUnits.esriDecimeters:
                    mapUnit = "分米";
                    break;
                case esriUnits.esriUnitsLast:
                    mapUnit = "内部单位";
                    break;
                default:
                    mapUnit = "未知单位";
                    break;
            }
            return mapUnit;
        }
    }
}
