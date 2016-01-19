using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Entity.Authorization
{
    public class Permission
    {
        public int Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public int IsDelete { get; set; }
    }
}
