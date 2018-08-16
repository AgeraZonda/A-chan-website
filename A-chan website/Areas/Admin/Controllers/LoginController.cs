using A_chan_website.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary2.Dao;
using A_chan_website.Common;

namespace A_chan_website.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.username, model.password);
                if(result)
                {
                    var user = dao.getByID(model.username);
                    var userSession = new UserLogin();
                    userSession.username = user.taikhoan;
                    userSession.UserID = user.maKH;

                    Session.Add(CommonConstants.USER_SESSION,userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("","Tài khoản hoặc mật khẩu sai.!");
                }
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không đúng");
            }
            
            return View("Index");
        }
	}
}