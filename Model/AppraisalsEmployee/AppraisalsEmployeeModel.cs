namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 考核人员表
    /// </summary>
    [DBTableInfo("tb_AppraisalsEmployee")]
    [Serializable]
    public partial class AppraisalsEmployeeModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? AppraisalsEmployeeID
        {
            get { return _appraisalsEmployeeID; }
            set { _appraisalsEmployeeID = value; }
        }

        ///<summary>
        ///考核年度
        ///</summary>
        [RequiredAll(ErrorMessage = "考核年度不能为空")]        [StringLength(64,ErrorMessage = "考核年度长度不能超过64")]
        public string AppraisalsYear
        {
            get { return _appraisalsYear; }
            set { _appraisalsYear = value; }
        }

        ///<summary>
        ///工号
        ///</summary>
        [RequiredAll(ErrorMessage = "工号不能为空")]        [StringLength(64,ErrorMessage = "工号长度不能超过64")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///姓名*
        ///</summary>
               [StringLength(64,ErrorMessage = "姓名*长度不能超过64")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary>
        ///人员部门*
        ///</summary>
               [StringLength(64,ErrorMessage = "人员部门*长度不能超过64")]
        public string Orgeh
        {
            get { return _orgeh; }
            set { _orgeh = value; }
        }

        ///<summary>
        ///考核性质（不考核人员、正常考核人员等等）*
        ///</summary>
               [StringLength(64,ErrorMessage = "考核性质（不考核人员、正常考核人员等等）*长度不能超过64")]
        public string AppraisalsType
        {
            get { return _appraisalsType; }
            set { _appraisalsType = value; }
        }

        ///<summary>
        ///减免系数*
        ///</summary>
               [StringLength(64,ErrorMessage = "减免系数*长度不能超过64")]
        public string DecreaseValue
        {
            get { return _decreaseValue; }
            set { _decreaseValue = value; }
        }

        ///<summary>
        ///考核人员类型（1000，2000根据人事视图，教师、行政）*
        ///</summary>
               [StringLength(64,ErrorMessage = "考核人员类型（1000，2000根据人事视图，教师、行政）*长度不能超过64")]
        public string PernrType
        {
            get { return _pernrType; }
            set { _pernrType = value; }
        }

        ///<summary>
        ///是否部门考核管理（标识是否有权限进行部门打分）*
        ///</summary>
              
        public bool? IsOrgReview
        {
            get { return _isOrgReview; }
            set { _isOrgReview = value; }
        }

        ///<summary>
        ///是否部门院系领导（部门主任、分管领导、系主任）*
        ///</summary>
              
        public bool? IsOrgLeader
        {
            get { return _isOrgLeader; }
            set { _isOrgLeader = value; }
        }

        ///<summary>
        ///部门打分评委权重（2,1。非部门打分人为空）
        ///</summary>
              
        public int? IsOrgehReview
        {
            get { return _isOrgehReview; }
            set { _isOrgehReview = value; }
        }

        ///<summary>
        ///考核状态
        ///</summary>
              
        public int? AppraisalsStatus
        {
            get { return _appraisalsStatus; }
            set { _appraisalsStatus = value; }
        }

        ///<summary>
        ///教师类型（如果是教师）*
        ///</summary>
              
        public int? TeacherType
        {
            get { return _teacherType; }
            set { _teacherType = value; }
        }

        ///<summary>
        ///是否未完全在岗人员*
        ///</summary>
              
        public bool? IsNotAllWork
        {
            get { return _isNotAllWork; }
            set { _isNotAllWork = value; }
        }

        ///<summary>
        ///在岗天数*
        ///</summary>
              
        public int? WorkDays
        {
            get { return _workDays; }
            set { _workDays = value; }
        }

        ///<summary>
        ///最终考核系数
        ///</summary>
               [StringLength(64,ErrorMessage = "最终考核系数长度不能超过64")]
        public string FinalResult
        {
            get { return _finalResult; }
            set { _finalResult = value; }
        }

        ///<summary>
        ///最终考核结果文本
        ///</summary>
              
        public string FinalResultText
        {
            get { return _finalResultText; }
            set { _finalResultText = value; }
        }

        ///<summary>
        ///非完整流程评定结果备注（如教学单项考核不合格直接给分，部门领导直接给分等情况）
        ///</summary>
              
        public string SpecialResultMemo
        {
            get { return _specialResultMemo; }
            set { _specialResultMemo = value; }
        }

        ///<summary>
        ///学校考核结果（仅文字描述）
        ///</summary>
              
        public string SchoolResult
        {
            get { return _schoolResult; }
            set { _schoolResult = value; }
        }

        ///<summary>
        ///个人确认状态
        ///</summary>
              
        public int? CheckStatus
        {
            get { return _checkStatus; }
            set { _checkStatus = value; }
        }

        ///<summary>
        ///确认时间
        ///</summary>
              
        public DateTime? CheckTime
        {
            get { return _checkTime; }
            set { _checkTime = value; }
        }

        ///<summary>
        ///确认人
        ///</summary>
               [StringLength(64,ErrorMessage = "确认人长度不能超过64")]
        public string CheckUser
        {
            get { return _checkUser; }
            set { _checkUser = value; }
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
        [DBFieldInfo(ColumnName = "AppraisalsEmployeeID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _appraisalsEmployeeID;


		/// <summary>
        /// 考核年度
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 工号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 姓名*
        /// </summary>
        [DBFieldInfo(ColumnName = "Name", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _name;


		/// <summary>
        /// 人员部门*
        /// </summary>
        [DBFieldInfo(ColumnName = "Orgeh", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgeh;


		/// <summary>
        /// 考核性质（不考核人员、正常考核人员等等）*
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsType", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsType;


		/// <summary>
        /// 减免系数*
        /// </summary>
        [DBFieldInfo(ColumnName = "DecreaseValue", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _decreaseValue;


		/// <summary>
        /// 考核人员类型（1000，2000根据人事视图，教师、行政）*
        /// </summary>
        [DBFieldInfo(ColumnName = "PernrType", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernrType;


		/// <summary>
        /// 是否部门考核管理（标识是否有权限进行部门打分）*
        /// </summary>
        [DBFieldInfo(ColumnName = "IsOrgReview", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isOrgReview;


		/// <summary>
        /// 是否部门院系领导（部门主任、分管领导、系主任）*
        /// </summary>
        [DBFieldInfo(ColumnName = "IsOrgLeader", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isOrgLeader;


		/// <summary>
        /// 部门打分评委权重（2,1。非部门打分人为空）
        /// </summary>
        [DBFieldInfo(ColumnName = "IsOrgehReview", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _isOrgehReview;


		/// <summary>
        /// 考核状态
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _appraisalsStatus;


		/// <summary>
        /// 教师类型（如果是教师）*
        /// </summary>
        [DBFieldInfo(ColumnName = "TeacherType", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _teacherType;


		/// <summary>
        /// 是否未完全在岗人员*
        /// </summary>
        [DBFieldInfo(ColumnName = "IsNotAllWork", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isNotAllWork;


		/// <summary>
        /// 在岗天数*
        /// </summary>
        [DBFieldInfo(ColumnName = "WorkDays", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _workDays;


		/// <summary>
        /// 最终考核系数
        /// </summary>
        [DBFieldInfo(ColumnName = "FinalResult", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _finalResult;


		/// <summary>
        /// 最终考核结果文本
        /// </summary>
        [DBFieldInfo(ColumnName = "FinalResultText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _finalResultText;


		/// <summary>
        /// 非完整流程评定结果备注（如教学单项考核不合格直接给分，部门领导直接给分等情况）
        /// </summary>
        [DBFieldInfo(ColumnName = "SpecialResultMemo", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _specialResultMemo;


		/// <summary>
        /// 学校考核结果（仅文字描述）
        /// </summary>
        [DBFieldInfo(ColumnName = "SchoolResult", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _schoolResult;


		/// <summary>
        /// 个人确认状态
        /// </summary>
        [DBFieldInfo(ColumnName = "CheckStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _checkStatus;


		/// <summary>
        /// 确认时间
        /// </summary>
        [DBFieldInfo(ColumnName = "CheckTime", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.DateTime, OrderIndex = -1, OrderAsc = true)]
        protected DateTime? _checkTime;


		/// <summary>
        /// 确认人
        /// </summary>
        [DBFieldInfo(ColumnName = "CheckUser", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _checkUser;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
