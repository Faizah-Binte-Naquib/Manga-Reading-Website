using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mango.Controllers
{
    public class RegisterController : Controller
    {
        string connectionString = "Data Source = DESKTOP-KPJ0U2U; Initial Catalog = trial; Integrated Security = True";

        // GET: Register
 

        [HttpGet]

        public ActionResult Register1()
        {
            //return View("~/Views/User/Login.cshtml");
            return View(new Models.UserModel());
        }


        [HttpPost]
        public ActionResult Register1(Models.UserModel user)
        {
            int flag = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "INSERT INTO userlogin VALUES (@useremail,@password,@username)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", user.Name);
                sqlCommand.Parameters.AddWithValue("@useremail", user.Email);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                string conpass = user.ConfirmPassword;
                sqlCommand.ExecuteNonQuery();
                flag = 1;
            }
            if (flag == 1)
                return View("~/Views/User/Login.cshtml");
            else
                return View("~/Views/User/Login.cshtml");



        }
    }
}