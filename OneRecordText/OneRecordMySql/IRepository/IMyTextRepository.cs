using OneRecordMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordMySql.IRepository
{
    public interface IMyTextRepository :IBaseRepository<MyText>
    {
        //查询所有数据
        public Task<List<MyText>> query();

        public Task<int> Insert(MyText myText);
}
}
