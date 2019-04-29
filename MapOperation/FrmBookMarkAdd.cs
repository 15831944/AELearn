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
    public partial class FrmBookMarkAdd : Form
    {
        /// <summary>
        /// 书签名
        /// </summary>
        private string bookMarkName;
        /// <summary>
        /// 是否保存
        /// </summary>
        private bool isSave;
        /// <summary>
        /// 书签名
        /// </summary>
        public string BookMarkName { get => bookMarkName; }
        /// <summary>
        /// 是否保存
        /// </summary>
        public bool IsSave { get => isSave; }

        public FrmBookMarkAdd()
        {
            InitializeComponent();
        }
        //确认时属性赋值，控件清空
        private void btnOk_Click(object sender, EventArgs e)
        {
            isSave = true;
            bookMarkName = txtBookmark.Text;
            txtBookmark.Text = "";
            Close();
        }
        // 取消时关闭窗口复位属性（？？？非必要？？？）
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookmark.Text = "";
            isSave = false;
            Close();
        }
        // 载入窗口时将创建按钮禁用
        private void FrmBookMarkAdd_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
        }
        // 判断书签名是否为空字符串
        private void txtBookmark_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = txtBookmark.Text == "" ? false : true;
        }
    }
}
