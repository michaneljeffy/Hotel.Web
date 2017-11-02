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

        public string Location1 { get; set; }

        public string Location2 { get; set; }

        public double Point { get; set; }

        public int CommonPrice { get; set; }

        public string PointFrom { get; set; }

        public string Comment { get; set; }
    }
}