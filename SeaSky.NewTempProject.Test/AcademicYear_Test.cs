namespace UnitTest_SeaSky.NewTempProject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Practices.Unity;
    using SeaSky.StandardLib.MyModel;
    using System.Collections.Generic;
    using System.Transactions;
    using SeaSky.NewTempProject.Model;
    using SeaSky.NewTempProject.BLL;

    [TestClass]
    public class AcademicYear_Test
    {

        private IAcademicYearService AcademicYearService = ApplicationContext.Current.UnityContainer.Resolve<IAcademicYearService>();

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
        /// 获取学年表视图列表分页
        /// </summary>
        [TestMethod]
        public void ListViewPageAcademicYear_Test()
        {
            AcademicYearViewModel testModel = null;
            BaseResultModel<PageModel<AcademicYearViewModel>> result = AcademicYearService.ListViewPageAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new AcademicYearViewModel()
            {
                PageNO = 1,
                PageSize = 2,
                AcademicYearName = "测试AcademicYearName",
            };
            result = AcademicYearService.ListViewPageAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }

        /// <summary>
        /// 获取学年表列表分页
        /// </summary>
        [TestMethod]
        public void ListPageAcademicYear_Test()
        {
            AcademicYearInputModel testModel = null;
            BaseResultModel<PageModel<AcademicYearOutputModel>> result = AcademicYearService.ListPageAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess && result.Data.DataCount > 0, result.ErrorMessage);

            testModel = new AcademicYearInputModel()
            {
                PageNO = 1,
                PageSize = 2,
                AcademicYearName = "测试AcademicYearName",
            };
            result = AcademicYearService.ListPageAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);
        }

        /// <summary>
        /// 新增、修改学年表
        /// </summary>
        [TestMethod]
        public void ModifyAcademicYear_Test()
        {
            AcademicYearInputModel testModel = new AcademicYearInputModel()
            {
                AcademicYearName = "测试AcademicYearName",
                Term = "测试Term",
                InputStatus = 76,
            };
            BaseResultModel<AcademicYearOutputModel> result = AcademicYearService.ModifyAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);

            testModel = new AcademicYearInputModel()
            {
                AcademicYearID = result.Data.AcademicYearID,
                AcademicYearName = "测试AcademicYearName1",
            };
            result = AcademicYearService.ModifyAcademicYear(testModel);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);

            BaseResultModel<int> delResult = AcademicYearService.DeleteAcademicYear(new List<Guid?>() { testModel.AcademicYearID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }

        /// <summary>
        /// 获取单个学年表 
        /// </summary>
        [TestMethod]
        public void GetAcademicYear_Test()
        {
            AcademicYearInputModel testModel = new AcademicYearInputModel()
            {
                AcademicYearName = "测试AcademicYearName",
                Term = "测试Term",
                InputStatus = 14,
            };
            BaseResultModel<AcademicYearOutputModel> insModelResult = AcademicYearService.ModifyAcademicYear(testModel);
            Assert.IsTrue(insModelResult.IsSuccess, insModelResult.ErrorMessage);

            BaseResultModel<AcademicYearViewModel> result = AcademicYearService.GetAcademicYear(insModelResult.Data.AcademicYearID);
            Assert.IsTrue(result.IsSuccess, result.ErrorMessage);

            BaseResultModel<int> delResult = AcademicYearService.DeleteAcademicYear(new List<Guid?>() { insModelResult.Data.AcademicYearID });
            Assert.IsTrue(delResult.IsSuccess, delResult.ErrorMessage);
        }
        #endregion
    }


}
