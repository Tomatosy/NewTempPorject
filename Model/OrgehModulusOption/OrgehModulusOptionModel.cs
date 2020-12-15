namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 模块表
    /// </summary>
    [DBTableInfo("tb_OrgehModulusOption")]
    [Serializable]
    public partial class OrgehModulusOptionModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? OrgehModulusOptionID
        {
            get { return _orgehModulusOptionID; }
            set { _orgehModulusOptionID = value; }
        }

        ///<summary>
        ///部门考核系数
        ///</summary>
               [StringLength(50,ErrorMessage = "部门考核系数长度不能超过50")]
        public string OrgehModulusValue
        {
            get { return _orgehModulusValue; }
            set { _orgehModulusValue = value; }
        }

        ///<summary>
        ///部门考核评价文本
        ///</summary>
               [StringLength(50,ErrorMessage = "部门考核评价文本长度不能超过50")]
        public string OrgehModulusText
        {
            get { return _orgehModulusText; }
            set { _orgehModulusText = value; }
        }

        ///<summary>
        ///系数确认逻辑（<=0.1、>0.1 and <=0.2....）
        ///</summary>
               [StringLength(50,ErrorMessage = "系数确认逻辑（<=0.1、>0.1 and <=0.2....）长度不能超过50")]
        public string ModulusCond
        {
            get { return _modulusCond; }
            set { _modulusCond = value; }
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
        [DBFieldInfo(ColumnName = "OrgehModulusOptionID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgehModulusOptionID;


		/// <summary>
        /// 部门考核系数
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehModulusValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgehModulusValue;


		/// <summary>
        /// 部门考核评价文本
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehModulusText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgehModulusText;


		/// <summary>
        /// 系数确认逻辑（<=0.1、>0.1 and <=0.2....）
        /// </summary>
        [DBFieldInfo(ColumnName = "ModulusCond", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _modulusCond;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
