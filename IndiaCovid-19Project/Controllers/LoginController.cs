using IndiaCovid_19Project.Models;
using IndiaCovid_19Project.ProjectSettings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IndiaCovid_19Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserLogin user)
        {
            UserLogin dbUser = new UserLogin();
            SqlConnection connect = new SqlConnection(DatabaseSettings.DatabaseConnectionMSSQL);
            connect.Open();
            SqlCommand cmd = new SqlCommand("LoginUser", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dbUser.Username = dr["Username"].ToString();
                dbUser.Password = dr["Password"].ToString();
            }
            if (user.Username == dbUser.Username && user.Password == dbUser.Password)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("UserHomePage", "User");
            }
            return View();
        }
    }
}