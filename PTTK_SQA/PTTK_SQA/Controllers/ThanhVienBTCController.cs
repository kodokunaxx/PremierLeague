using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PTTK_SQA.Models.Entities;
using PTTK_SQA.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PTTK_SQA.Controllers
{
    public class ThanhVienBTCController : Controller
    {
        private IThanhVienBTCDAO _thanhVienBTCDAO;

        public ThanhVienBTCController(IThanhVienBTCDAO thanhVienBTCDAO)
        {
            _thanhVienBTCDAO = thanhVienBTCDAO;
        }

        [Route("DangNhap")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(ThanhVienBTC info)
        {
            try
            {
                ThanhVienBTC btc = _thanhVienBTCDAO.checkLogin(info.TenDangNhap, info.MatKhau);
                if(btc != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, btc.Ten),
                        new Claim(ClaimTypes.Role, "admin"),
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var props = new AuthenticationProperties();
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                    TempData["Login"] = null;
                    return RedirectToAction("", "TrangChu");
                }
                else
                {
                    TempData["Login"] = "fail";
                    return RedirectToAction("","DangNhap");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("DangXuat")]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("", "DangNhap");
        }
    }
}
