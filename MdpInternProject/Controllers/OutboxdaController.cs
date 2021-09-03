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
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Rotativa.MVC;

namespace MdpInternProject.Controllers
{
    public class OutboxdaController : Controller
    {
        [HttpGet]
        public ActionResult Outboxda(string profile, string type, string sender, string sender_vn, string receiver, string receiver_vn, string start_date, string end_date, DateTime? issue_date, short? gib_status)
        {

            DataTable dt = outbox_da.GetDataTable(profile, type, sender, sender_vn, receiver, receiver_vn, start_date, end_date, issue_date, gib_status);

            ViewBag.profile = profile;
            ViewBag.type = type;
            ViewBag.sender = sender;
            ViewBag.sender_vn = sender_vn;
            ViewBag.receiver = receiver;
            ViewBag.receiver_vn = receiver_vn;
            ViewBag.gib_status = gib_status;

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

        [HttpGet]
        public ActionResult Show(string uuid)
        {

            var xmlcontent = outbox_da.GetXmlContent(uuid);

            var encoded = true;
            var removePreambles = false;
            var showAttachments = false;

            var HtmlString = Operations.TransformXMLToHTML(xmlcontent, "outbox_da", encoded, removePreambles, "", showAttachments);
            if (uuid != null) { 
                ViewBag.HtmlString = HtmlString;
            }
            return View();
        }


        [HttpGet]
        public ActionResult PrintInvoicePdf(string uuid)
        {
            var report = new ViewAsPdf("Show", uuid) { FileName = "waybill.pdf" };
            return report;
        }

        public FileResult PrintInvoiceXml(string uuid)
        {
            var xmlcontent = outbox_da.GetXmlContent(uuid);
            string filename = "waybill_"+ uuid + ".xml";
            //return File(Encoding.UTF8.GetBytes(xmlcontent), "application/xml", "waybill.xml");
            return File(Encoding.ASCII.GetBytes(xmlcontent), "application/xml", filename);
        }


    }
}
    