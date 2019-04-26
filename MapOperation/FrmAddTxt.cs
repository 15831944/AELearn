using AddFile;
using ESRI.ArcGIS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapOperation
{
    public partial class FrmAddTxt : Form
    {
        /// <summary>
        /// 绑定的地图控件
        /// </summary>
        public AxMapControl mapControl { get; set; }
        /// <summary>
        /// 实例化本窗口
        /// </summary>
        /// <param name="mapControl">绑定的地图控件</param>
        public FrmAddTxt(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mapControl = mapControl;
        }

        #region 源文件目录选择
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "打开本地测量坐标文件";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "测量坐标文件（*.txt）|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = openFileDialog.FileName;
            }
        }
        #endregion

        #region 存储目录选择
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Shape文件（*.shp）|*.shp";
            if (File.Exists(txtSource.Text))
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(txtSource.Text);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txtSave.Text = saveFileDialog.FileName;
        }
        #endregion

        #region 加载文本文件
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateTxtBox())
            {
                AddTxtHelper addTxtHelper = new AddTxtHelper();
                addTxtHelper.AddTxt(mapControl, txtSource.Text, txtSave.Text);
                Close();
            }
        } 
        #endregion

        #region 关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 验证操作空间的有效性
        /// <summary>
        /// 验证空间的有效性
        /// </summary>
        /// <returns>是否有效</returns>
        private bool ValidateTxtBox()
        {
            if (txtSource.Text == "" || !File.Exists(txtSource.Text))
            {
                MessageBox.Show("测量数据无效，请重新选择！", "提示", MessageBoxButtons.OK);
                return false;
            }
            if (txtSave.Text == "" || Path.GetExtension(txtSave.Text).ToLower() != ".shp")
            {
                MessageBox.Show("保存路径无效，请重新选择！", "提示", MessageBoxButtons.OK);
                return false;
            }
            return true;
        } 
        #endregion
    }
}
