namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 360行政人员评价配置表
    /// </summary>
    [DBTableInfo("tb_Staff360Option")]
    [Serializable]
    public partial class Staff360OptionModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? Staff360OptionID
        {
            get { return _staff360OptionID; }
            set { _staff360OptionID = value; }
        }

        ///<summary>
        ///考核得分
        ///</summary>
               [StringLength(32,ErrorMessage = "考核得分长度不能超过32")]
        public string Staff360OptionValue
        {
            get { return _staff360OptionValue; }
            set { _staff360OptionValue = value; }
        }

        ///<summary>
        ///考核评价文本
        ///</summary>
              
        public string Staff360OptionText
        {
            get { return _staff360OptionText; }
            set { _staff360OptionText = value; }
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
        [DBFieldInfo(ColumnName = "Staff360OptionID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _staff360OptionID;


		/// <summary>
        /// 考核得分
        /// </summary>
        [DBFieldInfo(ColumnName = "Staff360OptionValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _staff360OptionValue;


		/// <summary>
        /// 考核评价文本
        /// </summary>
        [DBFieldInfo(ColumnName = "Staff360OptionText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _staff360OptionText;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
