using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mango.Models;
using System.Diagnostics;



namespace Mango.Controllers
{
    public class UserController : Controller
    {
        string connectionString = "Data Source = DESKTOP-KPJ0U2U; Initial Catalog = trial; Integrated Security = True";
        static UserModel currentUser;
        List<UserModel> lst;
        int flag = 0;

        // GET: User



        [HttpGet]

        public ActionResult Login()
        {
           // return View();
            return View(new UserModel());

        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            currentUser = new UserModel();
            //create a list to store each rows of database as an object
            lst = new List<UserModel>();

            

            // DataSet dataset = new DataSet();
            //string realPassword = "";
            string paswordFromUser = "";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                //correct uptil here

                SqlCommand cmd = new SqlCommand("SELECT * FROM userlogin WHERE email = '" + model.Email + "'");
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = sqlConnection;

                //READ FROM THE DATABASE
                SqlDataReader reader = cmd.ExecuteReader();

                //a temporary object that is used to store the data retrived by DataReader, is later added to the list
                UserModel temp = new UserModel();

                while(reader.Read())
                {
                    {
                        temp.Name = reader["username"].ToString();
                        temp.Email = reader["email"].ToString();
                        temp.Password = reader["password"].ToString();

                       // realPassword = reader["password"].ToString();
                    }


                    lst.Add(temp);
                }


                //qua's code

                /*SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT password FROM userlogin WHERE email = '" + model.Email + "'", sqlConnection);
                sqlDataAdapter.Fill(dataset);
                realPassword = dataset.Tables[0].Rows[0].ItemArray[0].ToString();
                */


                paswordFromUser = model.Password;


            }

            //lst[0] is used because we will get only one row for a specific login which will be placed
            //on the index of the list

            if (lst[0].Password == paswordFromUser)
            {
                //removing .com from the email for view purpose
                string temp =lst[0].Email.Replace(".com", "");
                currentUser.Email = temp;

                //take name
                currentUser.Name = lst[0].Name;

                //take password
                currentUser.Password = lst[0].Password;

                //sending the value to view
                ViewBag.Data = currentUser;

                //adding to session
                Session["user"] = currentUser;

                flag = 1;
                //  Profile();
                return View("~/Views/User/Profile.cshtml");
            }
            else
                return View();
        }


        public ActionResult Profile()
        {
            if(Session["user"]!=null)
            {
                //currentUser = new UserModel();

                //storing the user gotten thruough session in currentUser
                dynamic currentUser = Session["user"];

                //removing .com from the email for view purpose
                string temp = currentUser.Email.Replace(".com", "");
                currentUser.Email = temp;


                //sending the value to view
                ViewBag.Data = currentUser;


                return View();

            }
            else
                return View("~/Views/User/Login.cshtml");


        }
    }
}