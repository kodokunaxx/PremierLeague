using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class BanToChuc
    {
        public Guid Id { get; set; }
        public string TenBTC { get; set; }
        public string Hotline { get; set; }
        public string Email { get; set; }
        public string MoTa { get; set; }
        public List<ThanhVienBTC> ThanhVienBTCs { get; set; }
    }
}
