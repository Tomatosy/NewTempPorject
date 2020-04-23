using SeaSky.NewTempProject.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Transactions;
using SeaSky.NewTempProject.Model;
using SeaSky.StandardLib.MyModel;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        //ITestService TestService = ApplicationContext.Current.UnityContainer.Resolve<ITestService>();
        public ActionResult Index()
        {
            string url = Request.Url.ToString();
            return Redirect(url + "/swagger");
        }

        //public BaseResultModel<TestOutputModel> Test()
        //{
        //    TransactionOptions option = new TransactionOptions();
        //    option.IsolationLevel = IsolationLevel.ReadCommitted;
        //    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, option))
        //    {//创建事务
        //        TestInputModel m = new TestInputModel();
        //        m.Name = "test";
        //        var result = this.TestService.Test(m);
        //        if (!result.IsSuccess)
        //        {
        //            Transaction.Current.Rollback();
        //            return null;
        //        }
        //        //scope.Complete();
        //        return null;
        //    }            
        //}
    }
}
