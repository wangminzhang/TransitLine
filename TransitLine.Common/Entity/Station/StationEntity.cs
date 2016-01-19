using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Common.Entity.Station
{
    public class StationEntity
    {
        public string Id { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public List<string> lines { get; set; }
    }
}
