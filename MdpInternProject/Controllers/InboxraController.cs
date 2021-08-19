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
    public class InboxraController : Controller
    {

            [HttpGet]
            public ActionResult Inboxra(string number, string profile, string type, string sender, string sender_vn, string receiver, string receiver_vn, string start_date, string end_date, DateTime? issue_date, short? gib_status)
            {

                DataTable dt = inbox_ra.GetDataTable(number, profile, type, sender, sender_vn, receiver, receiver_vn, start_date, end_date, issue_date, gib_status);

                ViewBag.TotalResults = dt.Rows.Count;

                return View(dt);

            }
            ////-----------------------------------------------------------------
        }
    }