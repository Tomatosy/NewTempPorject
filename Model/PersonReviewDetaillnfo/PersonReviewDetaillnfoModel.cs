namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 个人德勤廉纪明细结果表
    /// </summary>
    [DBTableInfo("tb_PersonReviewDetaillnfo")]
    [Serializable]
    public partial class PersonReviewDetaillnfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? PersonReviewDetaillnfoID
        {
            get { return _personReviewDetaillnfoID; }
            set { _personReviewDetaillnfoID = value; }
        }

        ///<summary>
        ///考核年度
        ///</summary>
               [StringLength(32,ErrorMessage = "考核年度长度不能超过32")]
        public string AppraisalsYear
        {
            get { return _appraisalsYear; }
            set { _appraisalsYear = value; }
        }

        ///<summary>
        ///被考核人工号
        ///</summary>
               [StringLength(64,ErrorMessage = "被考核人工号长度不能超过64")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///序号
        ///</summary>
              
        public int? TbIndex
        {
            get { return _tbIndex; }
            set { _tbIndex = value; }
        }

        ///<summary>
        ///得分
        ///</summary>
               [StringLength(32,ErrorMessage = "得分长度不能超过32")]
        public string Point
        {
            get { return _point; }
            set { _point = value; }
        }

        ///<summary>
        ///扣减/加分原因
        ///</summary>
               [StringLength(128,ErrorMessage = "扣减/加分原因长度不能超过128")]
        public string CutReason
        {
            get { return _cutReason; }
            set { _cutReason = value; }
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
        [DBFieldInfo(ColumnName = "PersonReviewDetaillnfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _personReviewDetaillnfoID;


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
        /// 序号
        /// </summary>
        [DBFieldInfo(ColumnName = "TbIndex", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _tbIndex;


		/// <summary>
        /// 得分
        /// </summary>
        [DBFieldInfo(ColumnName = "Point", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _point;


		/// <summary>
        /// 扣减/加分原因
        /// </summary>
        [DBFieldInfo(ColumnName = "CutReason", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _cutReason;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
