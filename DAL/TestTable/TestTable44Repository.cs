using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Tomato.NewTempProject.Model;
using Tomato.StandardLib.MyBaseClass;
using Tomato.StandardLib.DAL.Base;
using Tomato.StandardLib.MyModel;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace Tomato.NewTempProject.DAL
{
    public class TestTable44Repository : DALBase<TestModel, TestOutputModel>
    {

        public TestTable44Repository() : base("BaseConn")
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
    }
}
