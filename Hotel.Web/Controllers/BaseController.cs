using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Web.DB;
using System.Runtime.Remoting.Messaging;

namespace Hotel.Web.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 把context实例放在单线程中
        /// </summary>
        public HotelDbContext context
        {
            get
            {
                HotelDbContext context = CallContext.GetData("DB") as HotelDbContext;
                if (context is null)
                {
                    context = new HotelDbContext();
                    CallContext.SetData("DB",context);
                }
                return context;
            }
        }

        /// <summary>
        /// 通过HttpContext把EF context放到单线程中
        /// </summary>
        public HotelDbContext DB
        {
            get
            {
                HotelDbContext Db = HttpContext.Items["DB"] as HotelDbContext;
                if (Db is null)
                {
                    Db = new HotelDbContext();
                    HttpContext.Items["DB"] = Db;
                }
                return Db;
            }
        }


        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}