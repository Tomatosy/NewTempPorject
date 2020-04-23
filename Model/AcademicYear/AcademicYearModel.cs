namespace SeaSky.NewTempProject.Model
{
    using SeaSky.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using SeaSky.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using SeaSky.StandardLib.FrameWork;

	/// <summary>
    /// 学年表
    /// </summary>
    [DBTableInfo("tb_AcademicYear")]
    [Serializable]
    public partial class AcademicYearModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? AcademicYearID
        {
            get { return _academicYearID; }
            set { _academicYearID = value; }
        }

        ///<summary>
        ///学年名称
        ///</summary>
        [RequiredAll(ErrorMessage = "学年名称不能为空")]        [StringLength(50,ErrorMessage = "学年名称长度不能超过50")]
        public string AcademicYearName
        {
            get { return _academicYearName; }
            set { _academicYearName = value; }
        }

        ///<summary>
        ///学期(秋季学期、冬季学期、春季学期、夏季小学期)
        ///</summary>
        [RequiredAll(ErrorMessage = "学期(秋季学期、冬季学期、春季学期、夏季小学期)不能为空")]        [StringLength(50,ErrorMessage = "学期(秋季学期、冬季学期、春季学期、夏季小学期)长度不能超过50")]
        public string Term
        {
            get { return _term; }
            set { _term = value; }
        }

        ///<summary>
        ///学年状态（开启、关闭）
        ///</summary>
              
        public int? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        ///<summary>
        ///工作量年度维护状态（开启、关闭）【子明细表的对应年度可维护性】
        ///</summary>
        [RequiredAll(ErrorMessage = "工作量年度维护状态（开启、关闭）【子明细表的对应年度可维护性】不能为空")]       
        public int? InputStatus
        {
            get { return _inputStatus; }
            set { _inputStatus = value; }
        }

        ///<summary>
        ///最后业务确认期限
        ///</summary>
              
        public DateTime? FinalActionTime
        {
            get { return _finalActionTime; }
            set { _finalActionTime = value; }
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
        [DBFieldInfo(ColumnName = "AcademicYearID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _academicYearID;


		/// <summary>
        /// 学年名称
        /// </summary>
        [DBFieldInfo(ColumnName = "AcademicYearName", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _academicYearName;


		/// <summary>
        /// 学期(秋季学期、冬季学期、春季学期、夏季小学期)
        /// </summary>
        [DBFieldInfo(ColumnName = "Term", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _term;


		/// <summary>
        /// 学年状态（开启、关闭）
        /// </summary>
        [DBFieldInfo(ColumnName = "Status", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _status;


		/// <summary>
        /// 工作量年度维护状态（开启、关闭）【子明细表的对应年度可维护性】
        /// </summary>
        [DBFieldInfo(ColumnName = "InputStatus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _inputStatus;


		/// <summary>
        /// 最后业务确认期限
        /// </summary>
        [DBFieldInfo(ColumnName = "FinalActionTime", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.DateTime, OrderIndex = -1, OrderAsc = true)]
        protected DateTime? _finalActionTime;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
