using System;

namespace PTTK_SQA.Models.Entities
{
    public class ThanhVienBTC
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã thành viên
        /// </summary>
        public string MaThanhVien { get; set; }
        /// <summary>
        /// Tên 
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        public string TenDangNhap { get; set; }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string MatKhau { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string DiaChi { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Lương
        /// </summary>
        public Double Luong { get; set; }
    }
}