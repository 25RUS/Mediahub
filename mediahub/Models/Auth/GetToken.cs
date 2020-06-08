using System;
using System.Collections.Generic;
using System.Text;

namespace mediahub.Models.Auth
{
    public class GetToken
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
