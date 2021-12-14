using System;

namespace PTTK_SQA.Models.Entities
{
    public class TrongTai
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã trọng tài
        /// </summary>
        public string MaTrongTai { get; set; }
        /// <summary>
        /// Tên 
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// SĐT
        /// </summary>
        public string SDT { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string DiaChi { get; set; }
        /// <summary>
        /// Số năm kinh nghiệm
        /// </summary>
        public int NamKinhNghiem { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string MoTa { get; set; }
    }
}