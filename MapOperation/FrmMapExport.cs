using CommonTools;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using System;
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
    public partial class FrmMapExport : Form
    {
        #region 字段及属性
        private string savePath = "";
        private IActiveView activeView;
        private IGeometry geometry = null;
        private bool isRegion = true;


        public IGeometry GetGeometry { set => geometry = value; }
        public bool IsRegion { set => isRegion = value; } 
        #endregion
        public FrmMapExport(IActiveView activeView)
        {
            InitializeComponent();
            this.activeView = activeView;
        }


        #region 取消及关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            activeView.GraphicsContainer.DeleteAllElements();
            activeView.Refresh();
            Dispose();
        }

        private void FrmMapExport_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeView.GraphicsContainer.DeleteAllElements();
            activeView.Refresh();
            Dispose();
        }
        #endregion

        #region 路径选择
        private void btnExPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "jpg|bmp|gig|tif|png|pdf";
            save.Filter = "JPGE 文件(*.jpg)|*.jpg|BMP 文件(*.bmp)|*.bmp|GIF 文件(*.gif)|*.gif|TIF 文件(*.tif)|*.tif|PNG 文件(*.png)|*.png|PDF 文件(*.pdf)|*.pdf";
            save.OverwritePrompt = true;
            save.Title = "保存为";
            txtExPath.Text = "";
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                savePath = save.FileName;
                txtExPath.Text = save.FileName;
            }
        }
        #endregion

        #region 分辨率及宽高获取
        private void FrmMapExport_Load(object sender, EventArgs e)
        {
            cboResolution.Text = activeView.ScreenDisplay.DisplayTransformation.Resolution.ToString();
            cboResolution.Items.Add(cboResolution.Text);
            if (isRegion)
            {
                IEnvelope envelope = geometry.Envelope;
                tagRECT rect = new tagRECT();
                activeView.ScreenDisplay.DisplayTransformation.TransformRect(envelope, ref rect, 9);
                if (cboResolution.Text != "")
                {
                    txtHeight.Text = rect.bottom.ToString();
                    txtWidth.Text = rect.right.ToString();
                }
            }
            else
            {
                if (cboResolution.Text != "")
                {
                    txtHeight.Text = activeView.ExportFrame.bottom.ToString();
                    txtWidth.Text = activeView.ExportFrame.right.ToString();
                }
            }
        }
        #endregion

        #region 分辨率改变
        private void cboResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            double num = (int)Math.Round(activeView.ScreenDisplay.DisplayTransformation.Resolution);
            if (cboResolution.Text == "")
            {
                txtWidth.Text = "";
                txtHeight.Text = "";
                return;
            }
            if (isRegion)
            {
                IEnvelope pEnvelope = geometry.Envelope;
                tagRECT pRECT = new tagRECT();
                activeView.ScreenDisplay.DisplayTransformation.TransformRect(pEnvelope, ref pRECT, 9);
                if (cboResolution.Text != "")
                {
                    txtWidth.Text = Math.Round((double)(pRECT.right * (double.Parse(cboResolution.Text) / (double)num))).ToString();
                    txtHeight.Text = Math.Round((double)(pRECT.bottom * (double.Parse(cboResolution.Text) / (double)num))).ToString();
                }
            }
            else
            {
                txtWidth.Text = Math.Round((double)(activeView.ExportFrame.right * (double.Parse(cboResolution.Text) / (double)num))).ToString();
                txtHeight.Text = Math.Round((double)(activeView.ExportFrame.bottom * (double.Parse(cboResolution.Text) / (double)num))).ToString();
            }
        }
        #endregion

        #region 导出地图
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (txtExPath.Text == "")
            {
                MessageBox.Show("请先确定导出路径!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cboResolution.Text == "")
            {
                if (txtExPath.Text == "")
                {
                    MessageBox.Show("请输入分辨率！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (Convert.ToInt16(cboResolution.Text) == 0)
            {
                MessageBox.Show("请正确输入分辨率！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    int resolution = int.Parse(cboResolution.Text);  //输出图片的分辨率
                    int width = int.Parse(txtWidth.Text);            //输出图片的宽度，以像素为单位
                    int height = int.Parse(txtHeight.Text);          //输出图片的高度，以像素为单位
                    ExportMapHelper.ExportView(activeView, geometry, resolution, width, height, savePath, isRegion);
                    activeView.GraphicsContainer.DeleteAllElements();
                    activeView.Refresh();
                    MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("导出失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        } 
        #endregion
    }
}
