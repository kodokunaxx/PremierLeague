using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class HoaDonLuongTT
    {
        public Guid Id { get; set; }
        public string MaHoaDon { get; set; }
        public int TongTien { get; set; }
        public DateTime ThoiGianXuatHD { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public ThanhVienBTC NguoiTao { get; set; }
        public TrongTai TrongTai { get; set; }
    }
}
