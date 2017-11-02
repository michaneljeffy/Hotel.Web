using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Hotel.Crawler;
using System.Threading.Tasks;
using Hotel.Web.DB;

namespace Hotel.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           /* Hotel.Web.DB.Hotel htl = new Hotel.Web.DB.Hotel() { Id = 1, Name = "123", Location = "hangzhou", Comment = "good" };

            using (var db = new Hotel.Web.DB.HotelDbContext())
            {
                db.Hotels.Add(htl);
                db.SaveChanges();
            }

            Console.WriteLine("添加成功");
            Console.ReadKey();*/
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
