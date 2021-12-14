using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class TKCauThuGhiBan : CauThu
    {
        public string TenDoiBong { get; set; }
        public int SoBanThang { get; set; }
        public int KienTao { get; set; }
        public int ThuHang { get; set; }
        public int ThoiGianThiDau { get; set; }
    }
}
