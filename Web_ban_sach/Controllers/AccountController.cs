using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ban_sach.Models;
using Web_ban_sach.Models.DAO;

namespace Web_ban_sach.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TAIKHOAN model)
        {
           
            if (ModelState.IsValid)
            {
                TAIKHOAN taikhoan = TAIKHOAN_DAO.Read(model.UserID);
                if(taikhoan == null)
                {
                    ModelState.AddModelError("UserID", "Ten dang nhap khong ton tai");
                    return View(model);
                }
                else
                {
                    if (model.Password != taikhoan.Password)
                    {
                        ModelState.AddModelError("Password", "Sai mat khau");
                        return View(model);
                    }
                }
                Session["TaiKhoan"] = taikhoan;
                Session.Timeout = 240;//4tieng
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
    }
}