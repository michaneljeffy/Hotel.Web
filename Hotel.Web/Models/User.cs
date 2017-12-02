using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Remark { get; set; }
        public int Age { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
    }
}