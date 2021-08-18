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
        public ActionResult Outboxda(string number,string profile, string type, string sender, string sender_vn, string receiver, string receiver_vn, string start_date, string end_date, DateTime? issue_date)
        {

            DataTable dt = outbox_da.GetDataTable(number, profile, type, sender, sender_vn, receiver, receiver_vn, start_date, end_date, issue_date);

            ViewBag.TotalResults = dt.Rows.Count;

            return View(dt);

        }
        ////-----------------------------------------------------------------
    }
}



    