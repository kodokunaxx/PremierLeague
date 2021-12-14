using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class TranDau
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã trận đấu
        /// </summary>
        public string MaTranDau { get; set; }
        /// <summary>
        /// Thời gian bắt đầu
        /// </summary>
        public DateTime ThoiGianBatDau { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
        /// <summary>
        /// Số vé
        /// </summary>
        public int SoVe { get; set; }
        /// <summary>
        /// Số phút bù giờ
        /// </summary>
        public int SoPhutBuGio { get; set; }
        /// <summary>
        /// Đội nhà
        /// </summary>
        public DoiBong_TranDau DoiNha { get; set; }
        /// <summary>
        /// Đội Khách
        /// </summary>
        public DoiBong_TranDau DoiKhach { get; set; }
        /// <summary>
        /// Sân đấu
        /// </summary>
        public SanDau SanDau { get; set; }
        /// <summary>
        /// Tổ trọng tài
        /// </summary>
        public ToTT ToTT { get; set; }
    }
}
