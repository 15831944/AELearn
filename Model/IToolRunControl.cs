using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 视图鼠标控制接口
    /// </summary>
    public interface IToolRunControl
    {
        /// <summary>
        /// 按下鼠标时运行
        /// </summary>
        void OnMouseDownRun();
        /// <summary>
        /// 抬起鼠标时运行
        /// </summary>
        void OnMouseUpRun();
        /// <summary>
        /// 移动鼠标时运行
        /// </summary>
        void OnMouseMoveRun();
    }
}
