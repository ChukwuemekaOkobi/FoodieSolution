using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Helpers
{
    public class JwtSetting
    {
        public string Site { get; set; }
        public string Audience { get; set; }
        public string ExpiryTime { get; set; }
        public string SecretKey { get; set; }

    }
}
