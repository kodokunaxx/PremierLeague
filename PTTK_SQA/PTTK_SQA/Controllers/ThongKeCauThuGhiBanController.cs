using Microsoft.AspNetCore.Mvc;
using PTTK_SQA.Models.Interface;
using PTTK_SQA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PTTK_SQA.Controllers
{
    [Authorize(Roles = "admin")]
    public class ThongKeCauThuGhiBanController : Controller
    {
        private ITKCauThuGhiBanDAO _tKCauThuGhiBanDAO;

        public ThongKeCauThuGhiBanController(ITKCauThuGhiBanDAO tKCauThuGhiBanDAO)
        {
            _tKCauThuGhiBanDAO = tKCauThuGhiBanDAO;
        }
        [Route("ThongKe")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ThongKe/ThongKeCauThu")]
        public IActionResult GDThongKeCauThuGhiBan()
        {
            List<TKCauThuGhiBan> lst = _tKCauThuGhiBanDAO.getTKCauThuGhiBan();
            ViewData["TKCauThu"] = lst;
            return View();
        }
    }
}
