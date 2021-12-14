using PTTK_SQA.Models.Entities;
using Dapper;
using PTTK_SQA.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace PTTK_SQA.Models.DAO
{
    public class SuKienDAO : BaseDAO<SuKien>, ISuKienDAO
    {
        public List<SuKien> getSuKienGhiBanTheoTranDauCuaDoiBong(Guid TranDauId, Guid DoiBong_TranDauId)
        {
            string sqlCommand = "proc_GetSuKienGhiBanTheoTranDauCuaDoiBong";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@TranDauId", TranDauId.ToString());
            dynamicParameters.Add($"@DoiBong_TranDauId", DoiBong_TranDauId.ToString());

            List<SuKien> lst = _dbConnection.Query<SuKien>(sqlCommand, param: dynamicParameters, commandType: CommandType.StoredProcedure).ToList();

            return lst;
        }
    }
}
