using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Entity.Authorization
{
    public class Account
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        public int IsDelete { get; set; }
    }
}
