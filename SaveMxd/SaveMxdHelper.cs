using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMxd
{
    /// <summary>
    /// 存储地图文档
    /// </summary>
    public class SaveMxdHelper
    {
        /// <summary>
        /// 原路径存储地图文档
        /// </summary>
        /// <param name="mapControl">要存储地图文档的控件</param>
        public void SaveMap(AxMapControl mapControl)
        {
            // 1.判断非空且存在
            string mxdName = mapControl.DocumentFilename;
            IMapDocument mapDoc = new MapDocumentClass();
            if (mxdName != null && mapControl.CheckMxFile(mxdName))
            {
                // 2.存在就进行可写判断
                if (mapDoc.get_IsReadOnly(mxdName))
                {
                    MessageBox.Show("不可保存，地图文档是只读的！", "提示");
                    mapDoc.Close();
                    return;
                }
            }
            else
            {
                // 3.不存在则创建路径
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "ArcMap文档（*.mxd）|*.mxd|ArcMap模板（*.mxt）|*.mxt";
                saveFileDialog.Title = "请选择要保存的路径";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mxdName = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }
            // 4.在指定的路径保存地图文档
            mapDoc.New(mxdName);
            mapDoc.ReplaceContents(mapControl.Map as IMxdContents);
            mapDoc.Save(mapDoc.UsesRelativePaths, true);
            mapDoc.Close();
            MessageBox.Show("保存地图文档成功！", "提示！");
        }
        /// <summary>
        /// 另存地图文档
        /// </summary>
        /// <param name="mapControl">要存储地图文档的控件</param>
        public void SaveAsMap(AxMapControl mapControl)
        {
            
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ArcMap文档（*.mxd）|*.mxd|ArcMap模板（*.mxt）|*.mxt";
            saveFileDialog.Title = "另存为";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IMapDocument mapDoc = new MapDocumentClass();
                string mxdName = saveFileDialog.FileName;
                mapDoc.New(mxdName);
                mapDoc.ReplaceContents(mapControl.Map as IMxdContents);
                mapDoc.Save(true, true);
                mapDoc.Close();
            }
            
        }
    }
}
