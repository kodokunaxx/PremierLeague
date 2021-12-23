using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PTTK_SQA.Models.Interface;
using PTTK_SQA.Models.Entities;
using Microsoft.AspNetCore.Authorization;

namespace PTTK_SQA.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("[controller]")]
    public class TranDauController : Controller
    {
        private ITranDauDAO _tranDauDAO;
        private ISuKienDAO _suKienDAO;

        public TranDauController(ITranDauDAO tranDauDAO, ISuKienDAO suKienDAO)
        {
            _tranDauDAO = tranDauDAO;
            _suKienDAO = suKienDAO;
        }

        public IActionResult GDTranDau()
        {
            try
            {
                string cauthu = HttpContext.Request.Query["ten"];
                string cauthuId = HttpContext.Request.Query["cauthuId"];
                if (cauthuId != null && cauthu != null)
                {
                    Dictionary<TranDau, List<SuKien>> dict = new Dictionary<TranDau, List<SuKien>>();
                    List<TranDau> lstTranDau = _tranDauDAO.getTranDauTheoCauThuGhiBan(Guid.Parse(cauthuId));
                    foreach (TranDau item in lstTranDau)
                    {
                        List<SuKien> lstSuKien = _suKienDAO.getSuKienGhiBanTheoTranDauCuaDoiBong(item.Id, item.DoiNha.Id);
                        dict.Add(item, lstSuKien);
                    }

                    List<string> lstInfo = new List<string>();
                    lstInfo.Add(cauthu); lstInfo.Add(lstTranDau[0].DoiNha.DoiBong.TenDoiBong);


                    ViewData["TKTranDau"] = dict;
                    ViewData["Info"] = lstInfo;
                }
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
