namespace Tomato.NewTempProject.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 数据字典表
    /// </summary>
    [DBTableInfo("tb_Dic")]
    [Serializable]
    public partial class DicModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? DicID
        {
            get { return _dicID; }
            set { _dicID = value; }
        }

        ///<summary>
        ///选择组名称
        ///</summary>
               [StringLength(50,ErrorMessage = "选择组名称长度不能超过50")]
        public string DicName
        {
            get { return _dicName; }
            set { _dicName = value; }
        }

        ///<summary>
        ///键
        ///</summary>
        [RequiredAll(ErrorMessage = "键不能为空")]        [StringLength(50,ErrorMessage = "键长度不能超过50")]
        public string DicValue
        {
            get { return _dicValue; }
            set { _dicValue = value; }
        }

        ///<summary>
        ///文本
        ///</summary>
        [RequiredAll(ErrorMessage = "文本不能为空")]       
        public string DicText
        {
            get { return _dicText; }
            set { _dicText = value; }
        }

        ///<summary>
        ///是否删除
        ///</summary>
        [RequiredAll(ErrorMessage = "是否删除不能为空")]       
        public bool? IsDelete
        {
            get { return _isDelete; }
            set { _isDelete = value; }
        }

        #region private property


		/// <summary>
        /// 主键ID
        /// </summary>
        [DBFieldInfo(ColumnName = "DicID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _dicID;


		/// <summary>
        /// 选择组名称
        /// </summary>
        [DBFieldInfo(ColumnName = "DicName", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _dicName;


		/// <summary>
        /// 键
        /// </summary>
        [DBFieldInfo(ColumnName = "DicValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _dicValue;


		/// <summary>
        /// 文本
        /// </summary>
        [DBFieldInfo(ColumnName = "DicText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _dicText;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
