using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTTK_SQA.Models.DAO;
using PTTK_SQA.Models.Interface;
using System;
using System.Linq;

namespace PTTK_SQA_Test
{
    [TestClass]
    public class Tests
    {
        private ITKCauThuGhiBanDAO _tKCauThuGhiBanDAO;
        private ITranDauDAO _tranDauDAO;
        private ISuKienDAO _suKienDAO;

        [TestInitialize]
        public void Initialize()
        {
            _tKCauThuGhiBanDAO = new TKCauThuGhiBanDAO();
            _tranDauDAO = new TranDauDAO();
            _suKienDAO = new SuKienDAO();
        }

        #region Test với dữ liệu đầu vào
        /// <summary>
        /// cầu thủ không tồn tại
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            Guid id = new Guid();
            var actual = _tranDauDAO.getTranDauTheoCauThuGhiBan(id);
            Assert.AreEqual(0, actual.Count());
        }

        /// <summary>
        /// cầu thủ tồn tại, không có bàn thắng
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            Guid id = new Guid("1199652f-58c2-37d3-5a71-153b37881afe");
            var actual = _tranDauDAO.getTranDauTheoCauThuGhiBan(id);
            Assert.AreEqual(0, actual.Count());
        }

        /// <summary>
        /// cầu thủ tồn tại,  có bàn thắng
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            Guid id = new Guid("351a2156-165c-12c5-5726-978952f080e4");
            var actual = _tranDauDAO.getTranDauTheoCauThuGhiBan(id);
            Assert.AreEqual(2, actual.Count());
        }
        #endregion
    }
}