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
    public class TranDauDAO : BaseDAO<TranDau>, ITranDauDAO
    {
        public List<TranDau> getTranDauTheoCauThuGhiBan(Guid CauThuId)
        {
            string sqlCommand = "proc_GetTranDauTheoCauThuGhiBan";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@CauThuId", CauThuId.ToString());
            DataTable db = new DataTable();

            var data = _dbConnection.ExecuteReader(sqlCommand, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            db.Load(data);

            List<TranDau> lst = new List<TranDau>();
            foreach (DataRow row in db.Rows)
            {
                TranDau td = new TranDau()
                {
                    Id = Guid.Parse(row["TranDauId"].ToString()),
                    MaTranDau = row["MaTranDau"].ToString(),
                    DoiNha = new DoiBong_TranDau()
                    {
                        Id = Guid.Parse(row["DoiBong_TranDauId"].ToString()),
                        SoBanThang = Int32.Parse(row["SoBanThang"].ToString()),
                        DoiBong = new DoiBong()
                        {
                            TenDoiBong = row["TenDoiTa"].ToString()
                        }
                    },
                    DoiKhach = new DoiBong_TranDau()
                    {
                        DoiBong = new DoiBong()
                        {
                            TenDoiBong = row["TenDoiThu"].ToString()
                        }
                    }
                };
                lst.Add(td);
            }
            return lst;
        }
    }
}
