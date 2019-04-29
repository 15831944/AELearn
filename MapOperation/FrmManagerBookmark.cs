using ESRI.ArcGIS.Carto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapOperation
{
    public partial class FrmManagerBookmark : Form
    {
        #region 全局变量
        private IMap currentMap = null;
        Dictionary<string, ISpatialBookmark> dictionary = new Dictionary<string, ISpatialBookmark>();
        IMapBookmarks bookmarks;
        #endregion

        #region 构造方法
        /// <summary>
        /// 实例化窗口
        /// </summary>
        /// <param name="map">要操作的地图对象</param>
        public FrmManagerBookmark(IMap map)
        {
            InitializeComponent();
            currentMap = map;
            InitFrm();
        } 
        #endregion

        #region 初始化窗口
        /// <summary>
        /// 初始化窗口和控件
        /// </summary>
        private void InitFrm()
        {
            bookmarks = currentMap as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;
            enumSpatialBookmark.Reset();
            ISpatialBookmark spatialBookmark;
            while ((spatialBookmark = enumSpatialBookmark.Next()) != null)
            {
                dictionary.Add(spatialBookmark.Name, spatialBookmark);
                tviewBookMark.Nodes.Add(spatialBookmark.Name);
            }
        }
        #endregion

        #region 点击取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 点击删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 获得节点和书签
            TreeNode selectedNode = tviewBookMark.SelectedNode;
            ISpatialBookmark bookmark = dictionary[selectedNode.Text];
            // 删除字典、书签集合和空间中所对应的项
            dictionary.Remove(selectedNode.Text);
            bookmarks.RemoveBookmark(bookmark);
            tviewBookMark.Nodes.Remove(selectedNode);
            // 刷新
            tviewBookMark.Refresh();
        }
        #endregion

        #region 点击定位
        private void btnLocate_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tviewBookMark.SelectedNode;
            ISpatialBookmark bookmark = dictionary[selectedNode.Text];
            bookmark.ZoomTo(currentMap);
            IActiveView activeView = currentMap as IActiveView;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        }
        #endregion

        #region 节点双击定位
        private void tviewBookMark_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnLocate.PerformClick();
        } 
        #endregion
    }
}
