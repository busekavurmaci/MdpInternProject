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

        public FileResult PrintInvoicePdf(string uuid)
        {
            //if (uuid != null)
            //{
                var xmlcontent = outbox_da.GetXmlContent(uuid);
                var encoded = true;
                var removePreambles = false;
                var showAttachments = false;

                var HtmlString = Operations.TransformXMLToHTML(xmlcontent, "outbox_da", encoded, removePreambles, "", showAttachments);
                string dir = "c:\\Windows\\temp\\";
                string outputFileName = uuid + ".pdf";
                string inputFileName = dir + uuid + ".html";

                System.IO.File.WriteAllText(inputFileName, HtmlString,Encoding.UTF8);
                PdfGenerator.HtmlToPdf(dir, outputFileName, inputFileName);
            //}

            return File(dir+outputFileName, "application/pdf", outputFileName);
        }

        public FileResult PrintInvoiceXml(string uuid)
        {
            var xmlcontent = outbox_da.GetXmlContent(uuid);

            string filename = "waybill_"+ uuid + ".xml";

            byte[] encodedDataAsBytes = System.Convert.FromBase64String(xmlcontent);
            string returnValue = System.Text.Encoding.UTF8.GetString(encodedDataAsBytes);

            return File(Encoding.ASCII.GetBytes(returnValue), "application/xml", filename);
        }


    }
}
    