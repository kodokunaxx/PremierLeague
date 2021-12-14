using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class CauThu
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã cầu thủ
        /// </summary>
        public string MaCauThu { get; set; }
        /// <summary>
        /// Tên cầu thủ
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Chiều cao
        /// </summary>
        public string ChieuCao { get; set; }
        /// <summary>
        /// Cân nặng
        /// </summary>
        public string CanNang { get; set; }
        /// <summary>
        /// Chân thuận: trái-phải
        /// </summary>
        public string ChanThuan { get; set; }
        /// <summary>
        /// Số áo cầu thủ
        /// </summary>
        public int SoAo { get; set; }
        /// <summary>
        /// Vị Trí cầu thủ
        /// </summary>
        public VTCauThu ViTri { get; set; }
    }
}
