using System;
using System.Collections.Generic;

namespace PTTK_SQA.Models.Entities
{
    public class BangDau
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Tên bảng
        /// </summary>
        public string TenBang { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
        /// <summary>
        /// Danh sách đội bóng
        /// </summary>
        public List<DoiBong> DoiBongs { get; set; }
    }
}