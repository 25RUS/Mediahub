using System;
using System.Collections.Generic;
using System.Text;

namespace mediahub.Models.Auth
{
    public class Reg
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
    }
}
