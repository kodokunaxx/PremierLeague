using System;

namespace PTTK_SQA.Models.Entities
{
    public class TranDau_HopDong
    {
        public Guid Id { get; set; }
        public int TongTien { get; set; }
        public bool DaThanhToan { get; set; }
        public TranDau TranDau { get; set; }
    }
}