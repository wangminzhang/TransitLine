using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TransitLine.Common.EX
{
    [Serializable]
    public class CustomException : Exception, ISerializable
    {
        public int code { get; set; }
        public string message { get; set; }
        public CustomException(string msg, int code)
            : base()
        {
            this.message = msg;
            this.code = code;
        }

    }
}
