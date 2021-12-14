using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class HopDongBQTH
    {
        public Guid Id { get; set; }
        public string MaHopDong { get; set; }
        public string TenHopDong { get; set; }
        public string NoiDong { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayKy { get; set; }
        public string DiaDiem { get; set; }
        public DoiTac DoiTac { get; set; }
        public ThanhVienBTC ThanhVienBTC { get; set; }
        public List<TranDau_HopDong> TranDaus { get; set; }
    }
}
