namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 考核年度表
    /// </summary>
    [DBTableInfo("tb_AppraisalsYear")]
    [Serializable]
    public partial class AppraisalsYearModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? AppraisalsYearID
        {
            get { return _appraisalsYearID; }
            set { _appraisalsYearID = value; }
        }

        ///<summary>
        ///考核年度（学年中的年份关联）
        ///</summary>
               [StringLength(50,ErrorMessage = "考核年度（学年中的年份关联）长度不能超过50")]
        public string AppraisalsYear
        {
            get { return _appraisalsYear; }
            set { _appraisalsYear = value; }
        }

        ///<summary>
        ///考核批次状态（未生成、已生成、开启、关闭）
        ///</summary>
              
        public int? YearStatus
        {
            get { return _yearStatus; }
            set { _yearStatus = value; }
        }

        ///<summary>
        ///人事管理员确认数据状态（未确认，已确认）
        ///</summary>
              
        public int? HRCheckStatus
        {
            get { return _hRCheckStatus; }
            set { _hRCheckStatus = value; }
        }

        ///<summary>
        ///教学管理员确认数据状态（未确认，已确认）
        ///</summary>
              
        public int? TeaCheckStatus
        {
            get { return _teaCheckStatus; }
            set { _teaCheckStatus = value; }
        }

        ///<summary>
        ///行政人员最终考核结果状态（未完成、已完成）
        ///</summary>
              
        public int? StaffResultStatus
        {
            get { return _staffResultStatus; }
            set { _staffResultStatus = value; }
        }

        ///<summary>
        ///教师人员最终考核结果状态（未完成、已完成）
        ///</summary>
              
        public int? TeacherResultStatus
        {
            get { return _teacherResultStatus; }
            set { _teacherResultStatus = value; }
        }

        ///<summary>
        ///最后一次生成批次时间
        ///</summary>
              
        public DateTime? AppraisalsCreateTime
        {
            get { return _appraisalsCreateTime; }
            set { _appraisalsCreateTime = value; }
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
        [DBFieldInfo(ColumnName = "AppraisalsYearID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _appraisalsYearID;


		/// <summary>
        /// 考核年度（学年中的年份关联）
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 考核批次状态（未生成、已生成、开启、关闭）
        /// </summary>
        [DBFieldInfo(ColumnName = "YearStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _yearStatus;


		/// <summary>
        /// 人事管理员确认数据状态（未确认，已确认）
        /// </summary>
        [DBFieldInfo(ColumnName = "HRCheckStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _hRCheckStatus;


		/// <summary>
        /// 教学管理员确认数据状态（未确认，已确认）
        /// </summary>
        [DBFieldInfo(ColumnName = "TeaCheckStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _teaCheckStatus;


		/// <summary>
        /// 行政人员最终考核结果状态（未完成、已完成）
        /// </summary>
        [DBFieldInfo(ColumnName = "StaffResultStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _staffResultStatus;


		/// <summary>
        /// 教师人员最终考核结果状态（未完成、已完成）
        /// </summary>
        [DBFieldInfo(ColumnName = "TeacherResultStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _teacherResultStatus;


		/// <summary>
        /// 最后一次生成批次时间
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsCreateTime", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.DateTime, OrderIndex = -1, OrderAsc = true)]
        protected DateTime? _appraisalsCreateTime;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
