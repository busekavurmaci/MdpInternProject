using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Mdp.Entities;

namespace MdpInternProject.Controllers
{
    public class OutboxdaController : Controller
    {
       
        [HttpGet]
        public ActionResult Outboxda(string number,string profile, string type)
        {

            DataTable dt = outbox_da.GetDataTable(number, profile, type);

            ViewBag.TotalResults = dt.Rows.Count;

            return View(dt);


        }
        ////-----------------------------------------------------------------
    }
}



    