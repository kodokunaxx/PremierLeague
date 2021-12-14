using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Entities
{
    public class CauThu_DoiBong_TranDau
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Là đá chính: true-false
        /// </summary>
        public bool LaDaChinh { get; set; }
        /// <summary>
        /// Cầu thủ
        /// </summary>
        public CauThu CauThu { get; set; }
    }
}
