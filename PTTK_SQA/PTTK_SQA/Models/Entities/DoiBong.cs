using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class DoiBong
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã đội bóng
        /// </summary>
        public string MaDoiBong { get; set; }
        /// <summary>
        /// Tên đội bóng
        /// </summary>
        public string TenDoiBong { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AoSanNha { get; set; }
        /// <summary>
        /// Màu áo khi đá sân khách
        /// </summary>
        public string AoSanKhach { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
        /// <summary>
        /// Sân đấu
        /// </summary>
        public SanDau SanDau { get; set; }
        /// <summary>
        /// Danh sách cầu thủ
        /// </summary>
        public List<CauThu> CauThus { get; set; }
    }
}
