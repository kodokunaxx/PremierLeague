using System;

namespace PTTK_SQA.Models.Entities
{
    public class LoaiSuKien
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Tên sự kiện
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
    }
}