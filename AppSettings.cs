using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_authentication_netcore
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpireHours { get; set; }
        public string Emitter { get; set; }
        public string ValidateAt { get; set; }
    }
}
