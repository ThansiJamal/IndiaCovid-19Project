using IndiaCovid_19Project.Models;
using IndiaCovid_19Project.ProjectSettings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndiaCovid_19Project.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            SqlConnection connect = new SqlConnection(DatabaseSettings.DatabaseConnectionMSSQL);
            connect.Open();
            SqlCommand cmd = new SqlCommand("RegistrationSave", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@MobileNumber", user.MobileNumber);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@ConfirmPassword", user.ConfirmPassword);
            cmd.ExecuteNonQuery();
            connect.Close();
            return RedirectToAction("UserHomePage", "User");
            //View();
        }
    }
}