using Dapper;
using OneRecordMySql.Dapper;
using OneRecordMySql.IRepository;
using OneRecordMySql.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace OneRecordMySql.Repository
{
    public class waybillRepository : BaseRepository<waybill>, IwaybillRepository
    {
        public BaseDBContext _baseDB;
        public waybillRepository(BaseDBContext baseDB) : base(baseDB)
        {
            _baseDB = baseDB;
        }

        public async Task<int> Insert(waybill way)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("INSERT INTO waybill (waybillPrefix, waybillNumber,IdUrl,waybillType,PiecesCount,totalGrossWeight,goodsDescription,totalVolumetricWeight,Event) VALUES (@waybillPrefix, @waybillNumber,@IdUrl,@waybillType,@PiecesCount,@totalGrossWeight,@goodsDescription,@totalVolumetricWeight,@Event)", way);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /// <summary>
        /// 获取运单列表
        /// </summary>
        /// <param name="waybill"></param>
        /// <returns></returns>
        public async Task<List<waybill>> query(string? awb = "", string? goodsDescription = "", string? AirNo = "", string? flyStartTime = "", string? flyEndTime = "", string? downStartTime = "", string? downEndTime = "")
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                string sql = "SELECT * FROM  waybill WHERE ((waybillPrefix+waybillNumber) LIKE @awb OR MasterWab LIKE @awb ) and (goodsDescription LIKE @goodsDescription or goodsDescription is null) and ((Air+AirNo) Like @AirNo or (Air+AirNo) is null) "; //and startTime BETWEEN @flyStartTime AND @flyEndTime and endTime BETWEEN @downStartTime AND @downEndTime  
                var parameters = new
                {
                    awb = $"%{awb.Replace("-","")}%",
                    goodsDescription = $"%{goodsDescription}%",
                    AirNo = $"%{AirNo}%"
                };

                return await Task.Run(() => dbConnection.Query<waybill>(sql, parameters).ToList());
                //return await Task.Run(() => dbConnection.Query<waybill>("select * from waybill").Where(v=>(v.waybillPrefix + "-" + v.waybillNumber).Contains(awb) ||v.MasterWab.Contains(awb) || v.goodsDescription.Contains(goodsDescription)).ToList());
            }
        }

        public async Task<waybill> queryByLo(string IdUrl = "")
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                string sql = "SELECT * FROM  waybill WHERE IdUrl=@IdUrl"; //and startTime BETWEEN @flyStartTime AND @flyEndTime and endTime BETWEEN @downStartTime AND @downEndTime  
                var parameters = new
                {
                    IdUrl = IdUrl
                };

                return await Task.Run(() => dbConnection.Query<waybill>(sql, parameters).FirstOrDefault());
               
            }
        }

        public async Task<bool> queryWaybill(string waybillPrefix, string waybillNumber)
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                return await Task.Run(() => dbConnection.Query<waybill>("select * from waybill").Where(v => (v.waybillPrefix.Equals(waybillPrefix) && v.waybillNumber.Equals(waybillNumber))||v.MasterWab==(waybillPrefix+"-"+waybillNumber)).Count()>0);
            }
        }

        public async Task<bool> queryWaybillPhone(string IdUrl, string Phone)
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                string sql = "select * from waybill where IdUrl=@IdUrl and Phone =@Phone";
                var parameters = new
                {
                    IdUrl = IdUrl,
                    Phone = Phone
                };
                return await Task.Run(() => dbConnection.Query<waybill>(sql, parameters).Count() > 0);
            }
        }

        public async Task<int> Update(waybill way)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("UPDATE waybill SET Air=@Air,AirNo=@AirNo,startTime=@startTime,endTime=@endTime,MasterWab=@MasterWab,Event=@Event WHERE IdUrl=@IdUrl", way);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> UpdatePhone(waybill way)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("UPDATE waybill SET Phone=@Phone,Event=@Event WHERE IdUrl=@IdUrl", way);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> UpdateImgPath(waybill way)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("UPDATE waybill SET ImgPath=@ImgPath,Event=@Event WHERE IdUrl=@IdUrl", way);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> queryPhoto(string IdUrl)
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                string sql = "select * from waybill where IdUrl=@IdUrl";
                var parameters = new
                {
                    IdUrl = IdUrl
                };
                return await Task.Run(() => dbConnection.Query<waybill>(sql, parameters).FirstOrDefault().ImgPath);
            }
        }

        public async Task<int> UpdateEvent(waybill way)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("UPDATE waybill SET Event=@Event WHERE IdUrl=@IdUrl", way);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
