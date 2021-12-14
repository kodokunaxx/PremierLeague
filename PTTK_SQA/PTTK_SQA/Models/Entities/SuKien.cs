using System;

namespace PTTK_SQA.Models.Entities
{
    public class SuKien
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Thời điểm diễn ra sự kiện (phút)
        /// </summary>
        public int ThoiDiem { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string GhiChu { get; set; }
        /// <summary>
        /// Cầu thủ
        /// </summary>
        public CauThu_DoiBong_TranDau CauThu { get; set; }
        /// <summary>
        /// Loại sự kiện
        /// </summary>
        public LoaiSuKien LoaiSuKien { get; set; }
    }
}