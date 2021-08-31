using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Mdp.Entities;
using MdpInternProject.Utils;
using System.Xml;

namespace MdpInternProject.Controllers
{
    public class OutboxdaController : Controller
    {

        [HttpGet]
        public ActionResult Outboxda(string profile, string type, string sender, string sender_vn, string receiver, string receiver_vn, string start_date, string end_date, DateTime? issue_date, short? gib_status)
        {

            DataTable dt = outbox_da.GetDataTable(profile, type, sender, sender_vn, receiver, receiver_vn, start_date, end_date, issue_date, gib_status);

            ViewBag.TotalResults = dt.Rows.Count;

            return View(dt);

        }

        ////-----------------------------------------------------------------
        [HttpPost]
        public ActionResult Outboxda(string number)
        {

            DataTable dt = outbox_da.GetDataTable2(number);

            ViewBag.TotalResults = dt.Rows.Count;

            return View(dt);

        }

        [HttpPost]
        public ActionResult ViewInvoice(string xmlcontent, string box, Boolean encoded, bool removePreambles, string barcode, bool showAttachments)
        {
            outbox_da outboxda = new outbox_da();

            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath(xmlcontent));

            outboxda.xmlcontent = xmlcontent;
            encoded = true;
            removePreambles = false;
            showAttachments = false;
            //box = null;
            //barcode = null;
            
            var s = Operations.TransformXMLToHTML(xmlcontent, box, encoded, removePreambles, barcode, showAttachments);
            return View(s);

            //XmlDocument xmldc = new XmlDocument(xmlcontent);
            //return View(xmldc);
        }

    }
}
    