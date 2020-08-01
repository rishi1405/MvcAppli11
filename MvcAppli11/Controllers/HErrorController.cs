using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppli11.Controllers
{
    public class HErrorController : Controller
    {
        //
        // GET: /HError/

        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }

    }
}
