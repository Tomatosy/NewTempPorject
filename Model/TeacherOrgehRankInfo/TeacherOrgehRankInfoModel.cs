namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 教师类考核汇总排名表
    /// </summary>
    [DBTableInfo("tb_TeacherOrgehRankInfo")]
    [Serializable]
    public partial class TeacherOrgehRankInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? TeacherOrgehRankInfoID
        {
            get { return _teacherOrgehRankInfoID; }
            set { _teacherOrgehRankInfoID = value; }
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
        ///被考核人工号
        ///</summary>
               [StringLength(50,ErrorMessage = "被考核人工号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///考核人排名
        ///</summary>
              
        public int? PernrIndex
        {
            get { return _pernrIndex; }
            set { _pernrIndex = value; }
        }

        ///<summary>
        ///排名排序
        ///</summary>
              
        public int? PernrIndex2
        {
            get { return _pernrIndex2; }
            set { _pernrIndex2 = value; }
        }

        ///<summary>
        ///考核总得分
        ///</summary>
               [StringLength(50,ErrorMessage = "考核总得分长度不能超过50")]
        public string ResultPoint
        {
            get { return _resultPoint; }
            set { _resultPoint = value; }
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
        [DBFieldInfo(ColumnName = "TeacherOrgehRankInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _teacherOrgehRankInfoID;


		/// <summary>
        /// 考核年度
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 被考核人工号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 考核人排名
        /// </summary>
        [DBFieldInfo(ColumnName = "PernrIndex", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _pernrIndex;


		/// <summary>
        /// 排名排序
        /// </summary>
        [DBFieldInfo(ColumnName = "PernrIndex2", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _pernrIndex2;


		/// <summary>
        /// 考核总得分
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _resultPoint;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
