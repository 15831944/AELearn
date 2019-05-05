using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 工具获得结果
    /// </summary>
    public interface IToolGetResult
    {
        /// <summary>
        /// 得到结果
        /// </summary>
        /// <param name="Unit">单位</param>
        /// <returns>得到结果</returns>
        string GetResult(string Unit);
    }
}
