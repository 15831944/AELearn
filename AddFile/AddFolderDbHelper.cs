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
    /// 文件数据库加载
    /// </summary>
    public class AddFolderDbHelper
    {
        /// <summary>
        /// 文件数据库加载
        /// </summary>
        /// <param name="mapControl">要加载数据的控件</param>
        public void AddFileDb(AxMapControl mapControl)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            string fileDir = folderBrowserDialog.SelectedPath;
            if (fileDir == "") return;
            IWorkspaceFactory fileGDBWorkspaceFactory = new FileGDBWorkspaceFactoryClass();
            IWorkspace workspace = fileGDBWorkspaceFactory.OpenFromFile(fileDir, 0);
            LoadDatasetHelper loader = new LoadDatasetHelper();
            loader.AddAllDataset(workspace, mapControl);
        }
    }
}
