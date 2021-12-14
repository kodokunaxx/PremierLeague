using System;

namespace PTTK_SQA.Models.Entities
{
    public class VTCauThu
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string TenViTri { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
    }
}