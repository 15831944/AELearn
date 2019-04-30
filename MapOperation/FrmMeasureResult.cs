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
    public partial class FrmMeasureResult : Form
    {
        #region 窗口关闭事件
        public delegate void FrmCloseEventHandle();
        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        public event FrmCloseEventHandle frmClose; 
        #endregion

        public FrmMeasureResult()
        {
            InitializeComponent();
        }

        #region 窗口关闭
        private void FrmMeasureResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmClose != null)
            {
                frmClose();
            }
        } 
        #endregion
    }
}
