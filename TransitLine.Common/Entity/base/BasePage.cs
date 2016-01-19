using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Common.Entity
{
    class BasePage
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        public int Count { get; set; }
    }
}
