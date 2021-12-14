using System;
using System.Collections.Generic;

namespace PTTK_SQA.Models.Entities
{
    public class ToTT
    {
        public Guid Id { get; set; }
        public string MaToTT { get; set; }
        public string MoTa { get; set; }
        public List<TrongTai_ToTT> TrongTai_ToTT { get; set; }
    }
}