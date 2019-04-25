using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 加载各种类型地理数据的工具集
/// </summary>
namespace AddFile
{
    #region 地图文档加载
    /// <summary>
    /// 地图文档加载
    /// </summary>
    public class AddMxdHelper
    {
        #region 控件的LoadMxFile方法
        /// <summary>
        /// 控件的加载地图文档
        /// </summary>
        /// <param name="mapControl">要加载的地图控件</param>
        public void LoadMxFile(AxMapControl mapControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开MXD";
            openFileDialog.Filter = "ArcMap文档(*.mxd)|*.mxd;|ArcMap模板(*.mxt)|*.mxt|发布地图文件(*.pmf)|*.pmf|所有地图格式(*.mxd;*.mxt;*.pmf)|*.mxd;*.mxt;*.pmf";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if (fileName == "") return;
                if (mapControl.CheckMxFile(fileName))
                {
                    mapControl.LoadMxFile(fileName);
                }
                else
                {
                    MessageBox.Show(fileName + "是无效的地图文档，请检查后重新加载");
                    return;
                }
            }
        }
        #endregion

        #region IMapDocument接口的方法加载地图文档
        /// <summary>
        /// IMapDocument接口的open方法加载地图文档
        /// </summary>
        /// <param name="mapControl">加载地图文档的地图控件</param>
        public void IMapDocumentLoadMxd(AxMapControl mapControl)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.RestoreDirectory = true;
            openDialog.CheckFileExists = true;
            openDialog.Multiselect = false;
            openDialog.Title = "打开地图文档";
            openDialog.Filter = "ArcMap文档(*.mxd)|*.mxd;|ArcMap模板(*.mxt)|*.mxt|发布地图文件(*.pmf)|*.pmf|所有地图格式(*.mxd;*.mxt;*.pmf)|*.mxd;*.mxt;*.pmf";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDialog.FileName;
                if (fileName == "") return;
                if (mapControl.CheckMxFile(fileName))
                {
                    IMapDocument mapDocument = new MapDocument();
                    mapDocument.Open(fileName);
                    mapControl.Map = mapDocument.ActiveView.FocusMap;
                    mapControl.ActiveView.Refresh();
                }
            }
        }
        #endregion

        #region ICommand工具加载地图文档
        /// <summary>
        /// ICommand工具加载地图文档
        /// </summary>
        /// <param name="mapControl">要加载的控件</param>
        public void ICommandLoadMxd(AxMapControl mapControl)
        {
            ICommand cmd = new ControlsOpenDocCommandClass();
            cmd.OnCreate(mapControl.Object);
            cmd.OnClick();
        }
        #endregion
    } 
    #endregion
}
