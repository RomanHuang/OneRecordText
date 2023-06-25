using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordApiNew.Data.returnModel;
using OneRecordMySql.IRepository;
using OneRecordMySql.Models;

namespace OneRecordApiNew.Controllers.MySql
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MyTextController : ControllerBase
    {
        private IMyTextRepository Repository;
        public MyTextController(IMyTextRepository _repository)
        {
            Repository = _repository;
        }

        [HttpGet]
        public async Task<retData> query()
        {
            try
            {
                var data = await Repository.query();
                return new retData { Code = 200, data = data };
            }
            catch (Exception ex)
            {
                return new retData { Code = 500, data = ex.ToString() };
            }

        }


        [HttpPost]
        public async Task<retData> Create(MyText myText)
        {
            try
            {
                var ret = await Repository.Insert(myText);
                return new retData() { Code=200,data=ret};
            }
            catch (Exception ex)
            {
                return new retData { Code = 500, data = ex.Message };
            }
        }
    }
}

