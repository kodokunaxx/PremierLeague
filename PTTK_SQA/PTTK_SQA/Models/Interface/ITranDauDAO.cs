using PTTK_SQA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.Interface
{
    public interface ITranDauDAO
    {
        public List<TranDau> getTranDauTheoCauThuGhiBan(Guid CauThuId);
    }
}
