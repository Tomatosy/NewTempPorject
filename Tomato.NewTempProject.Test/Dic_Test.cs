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
    public class Dic_Test 
    {

        private IDicService DicService = ApplicationContext.Current.UnityContainer.Resolve<IDicService>();

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
        /// 获取数据字典表视图列表分页
        /// </summary>
        [TestMethod]
        public void ListViewPageDic_Test()
        {
            DicViewModel testModel = null;
            BaseResultModel<PageModel<DicViewModel>> result = DicService.ListViewPageDic(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new DicViewModel()
            {
                PageNO = 1,
                PageSize = 2,
                DicValue="测试DicValue"
				                 };
            result = DicService.ListViewPageDic(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }
		
        /// <summary>
        /// 获取数据字典表列表分页
        /// </summary>
        [TestMethod]
        public void ListPageDic_Test()
        {
            DicInputModel testModel = null;
            BaseResultModel<PageModel<DicOutputModel>> result = DicService.ListPageDic(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new DicInputModel()
            {
                PageNO = 1,
                PageSize = 2,
                DicValue="测试DicValue"
				                 };
            result = DicService.ListPageDic(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }

        /// <summary>
        /// 新增、修改数据字典表
        /// </summary>
        [TestMethod]
        public void ModifyDic_Test()
        {
            DicInputModel testModel = new DicInputModel()
            {
DicValue = "测试DicValue",
            DicText = "测试DicText",
            };
            BaseResultModel<DicOutputModel> result = DicService.ModifyDic(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);

            testModel = new DicInputModel()
            {
                DicID= result.Data.DicID,
            };
            result = DicService.ModifyDic(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
			
            BaseResultModel<int> delResult = DicService.DeleteDic(new List<Guid?>() { testModel.DicID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }

        /// <summary>
        /// 获取单个数据字典表 
        /// </summary>
        [TestMethod]
        public void GetDic_Test()
        {
            DicInputModel testModel = new DicInputModel()
            {
DicValue = "测试DicValue",
            DicText = "测试DicText",
                        };
            BaseResultModel<DicOutputModel> insModelResult = DicService.ModifyDic(testModel);
            Assert.IsTrue(insModelResult.IsSuccess, insModelResult.ErrorMessage);

            BaseResultModel<DicViewModel> result = DicService.GetDic(insModelResult.Data.DicID);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
			
            BaseResultModel<int> delResult = DicService.DeleteDic(new List<Guid?>() { insModelResult.Data.DicID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }
        #endregion
    }


}
