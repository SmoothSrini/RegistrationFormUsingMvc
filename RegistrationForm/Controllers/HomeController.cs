using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(CsRegister reg)
        {
            SqlConnection con = null;

            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ToString());
                SqlCommand cmd = new SqlCommand("sp_Insert_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@CustomerID", 0);  
                cmd.Parameters.AddWithValue("@Name", reg.Name);
                cmd.Parameters.AddWithValue("@Age", reg.Age);
                cmd.Parameters.AddWithValue("@Mobileno", reg.Phoneno);
                cmd.Parameters.AddWithValue("@EmailID", reg.Email);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
               
            }
            finally
            {
                con.Close();
            }
            return View();
        }
    }
}