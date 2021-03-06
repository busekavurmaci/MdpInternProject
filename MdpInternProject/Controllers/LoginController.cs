using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Mdp.Entities;
using System.Configuration;
using System.Text;

namespace MdpInternProject.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            //-- form authentication
            HttpCookie cookie = Request.Cookies["cerezim"];
            if (cookie != null)
            {
                ViewBag.username = cookie["username"].ToString();
                ViewBag.passwd = cookie["passwd"].ToString();
            }
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
                if (userr.RememberMe == true)
                {
                    HttpCookie cerez = new HttpCookie("cerezim");
                    cerez.Expires = DateTime.Now.AddYears(1); // Süre(1 yıl)
                    cerez.Values.Add("username", userr.username);
                    cerez.Values.Add("passwd", userr.passwd);
                    Response.Cookies.Add(cerez);

                    cerez = Request.Cookies["cerezim"];

                    if (cerez != null)
                    {
                        ViewBag.username = cerez["username"].ToString();
                    }
                }
                Session["username"] = userr.username.ToString();
                Session["passwd"] = userr.passwd.ToString();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre yanlış!";
            }
            sqlcon.Close();
            return View();
        }

    }

}