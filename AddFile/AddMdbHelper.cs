using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFile
{
    /// <summary>
    /// mdb数据加载
    /// </summary>
    public class AddMdbHelper
    {
        #region 个人数据库加载
        /// <summary>
        /// 添加mdb文件
        /// </summary>
        /// <param name="mapControl">要添加数据的控件</param>
        public void AddMdb(AxMapControl mapControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Personal Geodatabase(*.mdb)|*.mdb";
            openFileDialog.Title = "打开PersonGeodatabase文件";
            openFileDialog.ShowDialog();
            string fullPath = openFileDialog.FileName;
            if (fullPath == "") return;
            IWorkspaceFactory workspaceFactory = new AccessWorkspaceFactory();
            IWorkspace workspace = workspaceFactory.OpenFromFile(fullPath, 0);
            LoadDatasetHelper loadDatasetHelper = new LoadDatasetHelper();
            loadDatasetHelper.AddAllDataset(workspace, mapControl);
        } 
        #endregion
    }
}
