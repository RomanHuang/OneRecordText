using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordMySql.IRepository
{
    public interface IBaseRepository<T>
    {
        Task<int> Insert(T entity, string insertSql);

        Task<int> Update(T entity, string updateSql);

        Task<int> Delete(int Id, string deleteSql);

        Task<List<T>> SelectAsync(string selectSql);

        Task<T> GetOne(int Id, string selectOneSql);

        Task<List<T>> GetList(int Id, string selectSql);
    }
}
