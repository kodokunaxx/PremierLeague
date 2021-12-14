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
    public class ThanhVienBTCDAO : BaseDAO<ThanhVienBTCDAO>, IThanhVienBTCDAO
    {
        public ThanhVienBTC checkLogin(string username, string password)
        {
            string sqlCommand = "proc_CheckLogin";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@TenDangNhap", username);
            dynamicParameters.Add($"@MatKhau", password);

            return _dbConnection.QueryFirstOrDefault<ThanhVienBTC>(sqlCommand, param: dynamicParameters, commandType: CommandType.StoredProcedure);
        }
    }
}
