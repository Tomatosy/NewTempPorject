using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SeaSky.NewTempProject.Model;
using SeaSky.StandardLib.MyBaseClass;
using SeaSky.StandardLib.DAL.Base;
using SeaSky.StandardLib.MyModel;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace SeaSky.NewTempProject.DAL
{
    public class TestTableRepository : DALPageBase<TestModel, TestOutputModel>, ITestTableRepository
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        public TestTableRepository() : base("NewTempProject", DatabaseMode.SqlClient)
        {
        }

        /// <summary>
        /// 获取数据库操作人
        /// </summary>
        /// <returns>操作人</returns>
        public override string GetOperater()
        {
            return ServiceContext.Current.UserName;
        }

        public PageModel<TestOutputModel> ListPage(TestInputModel model)
        {
            string sql = @"SELECT *,NewID() AS OrganizationID FROM [dbo].[TestTable]
                            WHERE [Name] like '%'+@Name+'%'
                            ";
            string orderBy = "ORDER BY [Name] DESC";
            Collection<IDataParameter> parms = new Collection<IDataParameter>();
            parms.Add(new SqlParameter("@Name", "test"));
            return base.ListPage(sql, model.PageNO ?? 1, model.PageSize ?? 10, parms, orderBy);
        }
    }
}
