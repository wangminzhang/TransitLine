using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Common.Entity.Line
{
    public class LineEntity
    {
        /// <summary>
        /// 线路名称
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 线路信息包括线路类型、票价、首末班车时间等
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        ///  经过的站台信息
        /// </summary>
        public List<Stats> Stats { get; set; }
    }

    /// <summary>
    /// 站台信息
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// 站台名称
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 站台纬度
        /// </summary>
        public double lat { get; set; }
        /// <summary>
        /// 站台经度
        /// </summary>
        public double lng { get; set; }
    }
}
