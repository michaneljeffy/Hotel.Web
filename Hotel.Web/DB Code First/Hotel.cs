using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.DB
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Comment { get; set; }
    }
}