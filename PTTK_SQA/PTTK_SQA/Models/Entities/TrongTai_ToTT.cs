using System;

namespace PTTK_SQA.Models.Entities
{
    public class TrongTai_ToTT
    {
        public Guid Id { get; set; }
        public int TienCong { get; set; }
        public bool DaThanhToan { get; set; }
        public VTTrongTai ViTri { get; set; }
        public TrongTai TrongTai { get; set; }
    }
}