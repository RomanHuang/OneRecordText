using Dapper;
using OneRecordMySql.Dapper;
using OneRecordMySql.IRepository;
using OneRecordMySql.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace OneRecordMySql.Repository
{
    public class MyTextRepository : BaseRepository<MyText>, IMyTextRepository
    {
        public BaseDBContext _baseDB;
        public MyTextRepository(BaseDBContext baseDB) : base(baseDB)
        {
            _baseDB = baseDB;
        }

        public async Task<int> Insert(MyText myText)
        {
            try
            {
                using (IDbConnection dbConnection = _baseDB.Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.ExecuteAsync("INSERT INTO mytext (name, user) VALUES (@name, @user)", myText);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<List<MyText>> query()
        {
            using (IDbConnection dbConnection = _baseDB.Connection)
            {
                dbConnection.Open();
                return await Task.Run(() => dbConnection.Query<MyText>("select * from MyText").ToList());
            }
        }

    }
}
