using SeaSky.StandardLib.MyAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSky.StandardLib.MyModel;
using SeaSky.NewTempProject.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace SeaSky.NewTempProject.Model
{
    [DBTableInfo("TestTable")]
    [Serializable]
    public class TestModel : BasePageModel
    {
        public Guid? ID { get => id; set => id = value; }
        [Required(ErrorMessage = "账号不能为空")]
        public string Name { get => name; set => name = value; }
        public int? IntTest { get => intTest; set => intTest = value; }
        public bool? BoolTest { get => boolTest; set => boolTest = value; }

        #region privvate property
        [DBFieldInfo(ColumnName = "ID", IsIdentity = false, IsKey = true, SqlDbType = SqlDbType.UniqueIdentifier
            , OrderIndex = -1, OrderAsc = true)]
        protected Guid? id;
        [DBFieldInfo(ColumnName = "Name", IsIdentity = false, IsKey = false, SqlDbType = SqlDbType.NVarChar
            , LikeEqual = EnumLikeMode.AllLike
            , DefaultValue = ""
            , OrderIndex = 0, OrderAsc = true)]
        protected string name;

        [DBFieldInfo(ColumnName = "intTest", IsIdentity = false, IsKey = false, SqlDbType = SqlDbType.Int
            , DefaultValue = EnumLogLevel.Debug
            , OrderIndex = -1, OrderAsc = true)]
        protected int? intTest;

        [DBFieldInfo(ColumnName = "boolTest", IsIdentity = false, IsKey = false, SqlDbType = SqlDbType.Bit
            , DefaultValue = false
            , OrderIndex = -1, OrderAsc = true)]
        protected bool? boolTest;
        #endregion
    }
}
