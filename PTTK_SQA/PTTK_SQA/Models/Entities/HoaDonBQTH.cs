using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class HoaDonBQTH
    {
        public Guid Id { get; set; }
        public string MaHoaDon { get; set; }
        public int TongTien { get; set; }
        public DateTime ThoiGianXuatHD { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public ThanhVienBTC NguoiTao { get; set; }
        public DoiBong DoiBong { get; set; }
        public List<DoiBong_TranDau> TranDaus { get; set; }
    }
}
