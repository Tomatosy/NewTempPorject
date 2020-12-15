namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 教师类考核数据汇总表
    /// </summary>
    [DBTableInfo("tb_TeacherOrgehResultlInfo")]
    [Serializable]
    public partial class TeacherOrgehResultlInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? TeacherOrgehResultlInfoID
        {
            get { return _teacherOrgehResultlInfoID; }
            set { _teacherOrgehResultlInfoID = value; }
        }

        ///<summary>
        ///考核年度
        ///</summary>
               [StringLength(50,ErrorMessage = "考核年度长度不能超过50")]
        public string AppraisalsYear
        {
            get { return _appraisalsYear; }
            set { _appraisalsYear = value; }
        }

        ///<summary>
        ///考核人工号
        ///</summary>
               [StringLength(50,ErrorMessage = "考核人工号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///教学总分
        ///</summary>
               [StringLength(50,ErrorMessage = "教学总分长度不能超过50")]
        public string LessonPoint
        {
            get { return _lessonPoint; }
            set { _lessonPoint = value; }
        }

        ///<summary>
        ///育人总分
        ///</summary>
               [StringLength(50,ErrorMessage = "育人总分长度不能超过50")]
        public string TeacherPoint
        {
            get { return _teacherPoint; }
            set { _teacherPoint = value; }
        }

        ///<summary>
        ///社会服务总分
        ///</summary>
               [StringLength(50,ErrorMessage = "社会服务总分长度不能超过50")]
        public string ServicePoint
        {
            get { return _servicePoint; }
            set { _servicePoint = value; }
        }

        ///<summary>
        ///SA科研总分
        ///</summary>
               [StringLength(50,ErrorMessage = "SA科研总分长度不能超过50")]
        public string SaPoint
        {
            get { return _saPoint; }
            set { _saPoint = value; }
        }

        ///<summary>
        ///其他科研总分
        ///</summary>
               [StringLength(50,ErrorMessage = "其他科研总分长度不能超过50")]
        public string OtherPoint
        {
            get { return _otherPoint; }
            set { _otherPoint = value; }
        }

        ///<summary>
        ///教学研究总得分
        ///</summary>
               [StringLength(50,ErrorMessage = "教学研究总得分长度不能超过50")]
        public string ReasearchPoint
        {
            get { return _reasearchPoint; }
            set { _reasearchPoint = value; }
        }

        ///<summary>
        ///是否为单项不合格人员
        ///</summary>
              
        public bool? IsBelow
        {
            get { return _isBelow; }
            set { _isBelow = value; }
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
        [DBFieldInfo(ColumnName = "TeacherOrgehResultlInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _teacherOrgehResultlInfoID;


		/// <summary>
        /// 考核年度
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 考核人工号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 教学总分
        /// </summary>
        [DBFieldInfo(ColumnName = "LessonPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _lessonPoint;


		/// <summary>
        /// 育人总分
        /// </summary>
        [DBFieldInfo(ColumnName = "TeacherPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _teacherPoint;


		/// <summary>
        /// 社会服务总分
        /// </summary>
        [DBFieldInfo(ColumnName = "ServicePoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _servicePoint;


		/// <summary>
        /// SA科研总分
        /// </summary>
        [DBFieldInfo(ColumnName = "SaPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _saPoint;


		/// <summary>
        /// 其他科研总分
        /// </summary>
        [DBFieldInfo(ColumnName = "OtherPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _otherPoint;


		/// <summary>
        /// 教学研究总得分
        /// </summary>
        [DBFieldInfo(ColumnName = "ReasearchPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reasearchPoint;


		/// <summary>
        /// 是否为单项不合格人员
        /// </summary>
        [DBFieldInfo(ColumnName = "IsBelow", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isBelow;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
