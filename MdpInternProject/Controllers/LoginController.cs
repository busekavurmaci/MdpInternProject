using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Mdp.Entities;
using System.Configuration;

namespace MdpInternProject.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user userr)
        {
            string maincon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(maincon);

            sqlcon.Open();
            string sqlquery = "SELECT username,passwd FROM [dbo].[user] WHERE username=@username AND passwd=@passwd ";

            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlcon);
            sqlcom.Parameters.AddWithValue("@username", userr.username);
            sqlcom.Parameters.AddWithValue("@passwd", userr.passwd);
            SqlDataReader sdr = sqlcom.ExecuteReader();

            if (sdr.Read())
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                //ViewData["message"] = "Kullanıcı adı veya şifre yanlış!";
                ViewBag.Message = "Kullanıcı adı veya şifre yanlış!";
                //return RedirectToAction("Login", "Login");
            }
            sqlcon.Close();
            return View();
        }
    }

}
