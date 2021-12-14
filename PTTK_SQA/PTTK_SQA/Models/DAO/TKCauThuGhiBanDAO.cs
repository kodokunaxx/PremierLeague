using Dapper;
using PTTK_SQA.Models.Entities;
using PTTK_SQA.Models.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.DAO
{
    public class TKCauThuGhiBanDAO : BaseDAO<TKCauThuGhiBan>, ITKCauThuGhiBanDAO
    {
        public List<TKCauThuGhiBan> getTKCauThuGhiBan()
        {
            string sqlCommand = "proc_GetTKCauThuGhiBans";

            List<TKCauThuGhiBan> lst = _dbConnection.Query<TKCauThuGhiBan>(sqlCommand, commandType: CommandType.StoredProcedure).ToList();

            return lst;
        }
    }
}
