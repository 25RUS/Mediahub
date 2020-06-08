using System;
using System.Collections.Generic;
using System.Text;

namespace mediahub.Models.Auth.RX
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    public class RootObject
    {
        public User user { get; set; }
    }
}
