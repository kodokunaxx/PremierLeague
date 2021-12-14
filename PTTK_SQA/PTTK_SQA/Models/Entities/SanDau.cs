using System;

namespace PTTK_SQA.Models.Entities
{
    public class SanDau
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Tên sân
        /// </summary>
        public string TenSan { get; set; }
        /// <summary>
        /// Số lượng ghế
        /// </summary>
        public int SoLuongGhe { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string DiaChi { get; set; }
    }
}