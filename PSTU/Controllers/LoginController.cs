using MySql.Data.MySqlClient;
using PSTU.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PSTU.Controllers
{
    public class LoginController : Controller
    {
        private bool connection_open;
        private MySqlConnection connection;

        //
        // GET: /Login/
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public bool DoLogin(string username, string password)
        {
            bool r = false;
            if (username != null && password != null)
            {
                r = validate_login(username, password);
            }

            return r;

        }

        private bool validate_login(string user, string pass)
        {
            Get_Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from users where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connection;
            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }


        private void Get_Connection()
        {
            connection_open = false;

            connection = new MySqlConnection();
            //connection = DB_Connect.Make_Connnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            //            if (db_manage_connnection.DB_Connect.OpenTheConnection(connection))
            if (Open_Local_Connection())
            {
                connection_open = true;
            }
            else
            {
                //					MessageBox::Show("No database connection connection made...\n Exiting now", "Database Connection Error");
                //					 Application::Exit();
            }

        }

        private bool Open_Local_Connection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}