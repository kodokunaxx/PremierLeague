using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Controllers
{
    [Authorize(Roles = "admin")]
    public class TrangChuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
