using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Tomato.NewTempProject.Model;
using Tomato.NewTempProject.DAL;
using System.Transactions;
using Tomato.NewTempProject.Model.Enum;
using Tomato.StandardLib.MyModel;

namespace Tomato.NewTempProject.BLL
{
    public class TestService : ITestService
    {
        [Dependency]
        // 依赖注入
        public ITestTableRepository TestTableRepository { get; set; }

        //直接New
        public TestTable44Repository TestTable44Repository = new TestTable44Repository();

        /// <summary>
        /// 测试用例
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<List<TestOutputModel>> Test(TestInputModel model)
        {
            try
            {
                List<TestOutputModel> result;
                result = this.TestTableRepository.List().ToList();

                //增
                this.TestTableRepository.Insert(model);
                var insertresult = this.TestTableRepository.InsertAndReturn(model);
                List<TestInputModel> list = new List<TestInputModel>();
                list.Add(model);
                list.Add(model);
                this.TestTableRepository.InsertCol(list.ToArray());


                using (this.TestTableRepository.BeginLikeMode())
                {// using里使用like查询
                    PageModel<TestOutputModel> m1 = this.TestTableRepository.ListPage(model);
                }
                //不模糊查询
                PageModel<TestOutputModel> m = this.TestTableRepository.ListPage(model);


                using (this.TestTableRepository.BeginLikeMode())
                {// using里使用like查询

                    //查
                    result = this.TestTableRepository.List(model).ToList();
                    model = new TestInputModel();
                    var pageresult = this.TestTableRepository.ListPage(model).ListData.ToList();
                    var mymodel = this.TestTableRepository.SelectWithModel(model);
                    mymodel.Name = "test2";
                    //改
                    this.TestTableRepository.UpdateWithKeys(mymodel);
                    var mymodel2 = this.TestTableRepository.SelectWithKeys(mymodel);
                    model.Name = "test2";
                    mymodel = new TestOutputModel();
                    mymodel.Name = "test3";
                    var listUpdateModel = this.TestTableRepository.UpdateWithModelAndReturn(mymodel, model);
                    mymodel2 = this.TestTableRepository.SelectWithKeys(mymodel);
                }

                // 删
                model.Timestamp = new byte[0];
                var i = this.TestTableRepository.DeleteWithModel(model);
                this.TestTableRepository.SelectWithModel(model);
                i = this.TestTableRepository.DeleteWithIdentity(1);
                this.TestTableRepository.Search(model,true);
                this.TestTableRepository.UpdateWithModel(model, model);
                i = this.TestTableRepository.DeleteWithKeys(
                        new TestInputModel() { ID = new Guid("F68AA6B5-7BA2-456E-85D7-BE31791B3FDF") }
                    );

                TransactionOptions option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    model.ID = new Guid("A317E4B2-A8C4-4E35-89A0-22A1F515E281");
                    this.TestTableRepository.Insert(model);
                    scope.Complete();
                }
                this.TestTableRepository.TruncateTable();

                //夸数据库事务
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    this.TestTable44Repository.InsertCol(list.ToArray());
                    scope.Complete();
                }
                return new SuccessResultModel<List<TestOutputModel>>(null);
            }
            catch(Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListData", "", "", "查询数据时发生错误.", e);
                return new ErrorResultModel<List<TestOutputModel>>("", "查询数据时发生错误");
            }
        }

        public BaseResultModel<TestOutputModel> CreateData(TestInputModel model)
        {
            try
            {
                var result = new SuccessResultModel<TestOutputModel>();
                result.Data = this.TestTableRepository.InsertAndReturn(model);
                return result;
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListData", "", "", "创建数据时发生错误.", e);
                return new ErrorResultModel<TestOutputModel>("", "创建数据时发生错误");
            }
        }

        public BaseResultModel<int> RemoveData(List<TestInputModel> model)
        {
            try
            {
                var result = new SuccessResultModel<int>();
                result.Data = 0;
                foreach (var item in model)
                {
                    result.Data += this.TestTableRepository.DeleteWithKeys(item);
                }
                return result;
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListData", "", "", "删除数据时发生错误.", e);
                return new ErrorResultModel<int>("", "删除数据时发生错误");
            }
        }
    }
}
