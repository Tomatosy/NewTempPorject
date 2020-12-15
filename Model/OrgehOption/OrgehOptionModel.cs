namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 部门考核配置表
    /// </summary>
    [DBTableInfo("tb_OrgehOption")]
    [Serializable]
    public partial class OrgehOptionModel : BasePageModel
    {


        ///<summary>
        ///配置ID（Guid）
        ///</summary>
              
        public Guid? OrgehOptionID
        {
            get { return _orgehOptionID; }
            set { _orgehOptionID = value; }
        }

        ///<summary>
        ///部门考核得分
        ///</summary>
               [StringLength(50,ErrorMessage = "部门考核得分长度不能超过50")]
        public string OrgehOptionValue
        {
            get { return _orgehOptionValue; }
            set { _orgehOptionValue = value; }
        }

        ///<summary>
        ///部门考核评价文本
        ///</summary>
               [StringLength(50,ErrorMessage = "部门考核评价文本长度不能超过50")]
        public string OrgehOptionText
        {
            get { return _orgehOptionText; }
            set { _orgehOptionText = value; }
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
        /// 配置ID（Guid）
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehOptionID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgehOptionID;


		/// <summary>
        /// 部门考核得分
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehOptionValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgehOptionValue;


		/// <summary>
        /// 部门考核评价文本
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehOptionText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgehOptionText;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
