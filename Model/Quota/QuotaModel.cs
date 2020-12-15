namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 工作量定额配置表
    /// </summary>
    [DBTableInfo("tb_Quota")]
    [Serializable]
    public partial class QuotaModel : BasePageModel
    {


        ///<summary>
        ///配置ID
        ///</summary>
              
        public Guid? QuotaID
        {
            get { return _quotaID; }
            set { _quotaID = value; }
        }

        ///<summary>
        ///教师分类ID
        ///</summary>
              
        public Guid? TeacherTypeID
        {
            get { return _teacherTypeID; }
            set { _teacherTypeID = value; }
        }

        ///<summary>
        ///教师分类名称（可选择是否储存冗余，通过人事视图可获得）
        ///</summary>
               [StringLength(64,ErrorMessage = "教师分类名称（可选择是否储存冗余，通过人事视图可获得）长度不能超过64")]
        public string TeacherTypeName
        {
            get { return _teacherTypeName; }
            set { _teacherTypeName = value; }
        }

        ///<summary>
        ///计算策略（例：LessonPoint，ServicePoint+SAPoint+OtherPoint）
        ///</summary>
               [StringLength(64,ErrorMessage = "计算策略（例：LessonPoint，ServicePoint+SAPoint+OtherPoint）长度不能超过64")]
        public string ConfigRoot
        {
            get { return _configRoot; }
            set { _configRoot = value; }
        }

        ///<summary>
        ///最低配置值
        ///</summary>
               [StringLength(64,ErrorMessage = "最低配置值长度不能超过64")]
        public string ConfigValue
        {
            get { return _configValue; }
            set { _configValue = value; }
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
        /// 配置ID
        /// </summary>
        [DBFieldInfo(ColumnName = "QuotaID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _quotaID;


		/// <summary>
        /// 教师分类ID
        /// </summary>
        [DBFieldInfo(ColumnName = "TeacherTypeID", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _teacherTypeID;


		/// <summary>
        /// 教师分类名称（可选择是否储存冗余，通过人事视图可获得）
        /// </summary>
        [DBFieldInfo(ColumnName = "TeacherTypeName", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _teacherTypeName;


		/// <summary>
        /// 计算策略（例：LessonPoint，ServicePoint+SAPoint+OtherPoint）
        /// </summary>
        [DBFieldInfo(ColumnName = "ConfigRoot", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _configRoot;


		/// <summary>
        /// 最低配置值
        /// </summary>
        [DBFieldInfo(ColumnName = "ConfigValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _configValue;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
