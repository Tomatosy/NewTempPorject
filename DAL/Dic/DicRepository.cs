﻿namespace SeaSky.NewTempProject.DAL
{
using Microsoft.Practices.Unity;
using SeaSky.StandardLib.MyBaseClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSky.StandardLib.DAL.Base;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using SeaSky.StandardLib.MyModel;
using SeaSky.NewTempProject.Model;

    public class DicRepository : DALPageBaseNew<DicModel,DicOutputModel, DicViewModel>, IDicRepository
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        public DicRepository() : base("NewTempProject", DatabaseMode.SqlClient)
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
