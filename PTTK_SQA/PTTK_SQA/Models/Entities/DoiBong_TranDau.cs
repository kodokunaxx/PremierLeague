using System;
using System.Collections.Generic;

namespace PTTK_SQA.Models.Entities
{
    public class DoiBong_TranDau
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Là đội nhà
        /// </summary>
        public bool LaDoiNha { get; set; }
        /// <summary>
        /// Số bàn thắng
        /// </summary>
        public int SoBanThang { get; set; }
        /// <summary>
        /// Tiền bản quyền truyền hình
        /// </summary>
        public int TienBanQuyen { get; set; }
        /// <summary>
        /// Đã thanh toán: true-false
        /// </summary>
        public bool DaThanhToan { get; set; }
        /// <summary>
        /// Hệ số doanh thu
        /// </summary>
        public double HeSoDoanhThu { get; set; }
        /// <summary>
        /// Điểm số
        /// </summary>
        public int Diem { get; set; }
        /// <summary>
        /// Đội bóng
        /// </summary>
        public DoiBong DoiBong { get; set; }
        /// <summary>
        /// Các sự kiện
        /// </summary>
        public List<SuKien> SuKiens { get; set; }
    }
}