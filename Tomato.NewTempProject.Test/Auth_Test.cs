namespace UnitTest_Tomato.NewTempProject
{
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Tomato.StandardLib.MyModel;
using System.Collections.Generic;
using System.Transactions;
using Tomato.NewTempProject.Model;
using Tomato.NewTempProject.BLL;

    [TestClass]
    public class Auth_Test 
    {

        private IAuthService AuthService = ApplicationContext.Current.UnityContainer.Resolve<IAuthService>();

        private TransactionScope scope;

        #region 附加测试特性

        [TestInitialize()]
        public void MyTestInitialize()
        {
            TransactionOptions transaction = new TransactionOptions();
            transaction.IsolationLevel = IsolationLevel.ReadCommitted;
            scope = new TransactionScope(TransactionScopeOption.Required, transaction);
        }

        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        [TestCleanup()]
        public void MyTestCleanup()
        {
            scope.Dispose();
        }
        #endregion


        #region 基础方法
        /// <summary>
        /// 获取用户权限表视图列表分页
        /// </summary>
        [TestMethod]
        public void ListViewPageAuth_Test()
        {
            AuthViewModel testModel = null;
            BaseResultModel<PageModel<AuthViewModel>> result = AuthService.ListViewPageAuth(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new AuthViewModel()
            {
                PageNO = 1,
                PageSize = 2,
                Pernr="测试Pernr"
				                 };
            result = AuthService.ListViewPageAuth(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }
		
        /// <summary>
        /// 获取用户权限表列表分页
        /// </summary>
        [TestMethod]
        public void ListPageAuth_Test()
        {
            AuthInputModel testModel = null;
            BaseResultModel<PageModel<AuthOutputModel>> result = AuthService.ListPageAuth(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new AuthInputModel()
            {
                PageNO = 1,
                PageSize = 2,
                Pernr="测试Pernr"
				                 };
            result = AuthService.ListPageAuth(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }

        /// <summary>
        /// 新增、修改用户权限表
        /// </summary>
        [TestMethod]
        public void ModifyAuth_Test()
        {
            AuthInputModel testModel = new AuthInputModel()
            {
Pernr = "测试Pernr",
                            Orgeh=Guid.NewGuid(),
                                RoleID=Guid.NewGuid(),
                };
            BaseResultModel<AuthOutputModel> result = AuthService.ModifyAuth(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);

            testModel = new AuthInputModel()
            {
                AuthID= result.Data.AuthID,
Pernr = "测试Pernr",
                        };
            result = AuthService.ModifyAuth(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
			
            BaseResultModel<int> delResult = AuthService.DeleteAuth(new List<Guid?>() { testModel.AuthID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }

        /// <summary>
        /// 获取单个用户权限表 
        /// </summary>
        [TestMethod]
        public void GetAuth_Test()
        {
            AuthInputModel testModel = new AuthInputModel()
            {
Pernr = "测试Pernr",
                            Orgeh=Guid.NewGuid(),
                                RoleID=Guid.NewGuid(),
                            };
            BaseResultModel<AuthOutputModel> insModelResult = AuthService.ModifyAuth(testModel);
            Assert.IsTrue(insModelResult.IsSuccess, insModelResult.ErrorMessage);

            BaseResultModel<AuthViewModel> result = AuthService.GetAuth(insModelResult.Data.AuthID);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
			
            BaseResultModel<int> delResult = AuthService.DeleteAuth(new List<Guid?>() { insModelResult.Data.AuthID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }
        #endregion
    }


}
