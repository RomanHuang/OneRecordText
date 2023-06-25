using OneRecordMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordMySql.IRepository
{
    public interface IwaybillRepository : IBaseRepository<waybill>
    {
        //查询所有数据
        public Task<List<waybill>> query(string? awb = "", string? goodsDescription = "", string? AirNo = "", string? flyStartTime = "", string? flyEndTime = "", string? downStartTime = "", string? downEndTime = "");
        public Task<waybill> queryByLo(string IdUrl = "");
        /// <summary>
        /// 查询是否有相同运单
        /// </summary>
        /// <param name="waybill"></param>
        /// <returns></returns>
        public Task<bool> queryWaybill(string waybillPrefix ,string waybillNumber);

        /// <summary>
        /// 查询是否有相同运单
        /// </summary>
        /// <param name="waybill"></param>
        /// <returns></returns>
        public Task<string> queryPhoto(string IdUrl);

        /// <summary>
        /// 查询手机号是否正确
        /// </summary>
        /// <param name="waybill"></param>
        /// <returns></returns>
        public Task<bool> queryWaybillPhone(string IdUrl, string Phone);

        public Task<int> Insert(waybill way);

        public Task<int> Update(waybill way);
        public Task<int> UpdatePhone(waybill way);

        public Task<int> UpdateImgPath(waybill way);
        public Task<int> UpdateEvent(waybill way);
    }
}
