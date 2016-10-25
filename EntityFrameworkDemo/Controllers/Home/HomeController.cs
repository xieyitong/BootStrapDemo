using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(FormCollection form)
        {
            string a = form["username"];
            string b = form["email"];
            //string a = Request["username"];
            //string b = Request["email"];
            return View();
        }

        public JsonResult GetPageData(string username, string password, string email, string repassword)
        {
            var result = "";// userinfoDataAccessors.CheckEmailIsexist(email);
            var json = Json(new
            {
                state = result
            }, JsonRequestBehavior.DenyGet);
            return json;
        }

        public JsonResult GetPassword(string email)
        {

            
            var result = EntityFrameworkDemo.DataAccess.SendEmail.SendEmailByUser(email);// userinfoDataAccessors.CheckEmailIsexist(email);
            var json = Json(new
            {
                state = result
            }, JsonRequestBehavior.DenyGet);
            return json;
        }
        //方法1:使用传统的Request请求取值
        //[HttpPost]
        //public ActionResult AddNews()
        //{
        //    string a = Request["text1"];
        //    string b = Request["text2"];
        //}
        //方法2:Action参数名与表单元素name值一一对应
        //[HttpPost]
        //public ActionResult AddNews(string text1, string text2)
        //{
        //    string a = text1;
        //    string b = text2;
        //}
        //方法3:从MVC封装的FormCollection容器中读取
        //[HttpPost]
        //public ActionResult AddNews(FormCollection form)
        //{
        //    string a = form["text1"];
        //    string b = form["text2"];
        //}
        //方法4:使用实体作为Action参数传入，前提是提交的表单元素名称与实体属性名称一一对应
        //[HttpPost]
        //public ActionResult AddNews(userModel user)
        //{
        //    string a = user.text1;
        //    string b = user.text2;
        //}


        public ActionResult Widgets()
        {
            return View();
        }

        public ActionResult ChartJs()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }

        public ActionResult Inline()
        {
            return View();
        }
    }
}