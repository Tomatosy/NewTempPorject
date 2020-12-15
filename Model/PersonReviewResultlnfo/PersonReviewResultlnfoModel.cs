namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 个人德勤廉纪结果汇总表
    /// </summary>
    [DBTableInfo("tb_PersonReviewResultlnfo")]
    [Serializable]
    public partial class PersonReviewResultlnfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? PersonReviewResultlnfoID
        {
            get { return _personReviewResultlnfoID; }
            set { _personReviewResultlnfoID = value; }
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
        ///部门内排名
        ///</summary>
              
        public int? ResultRank
        {
            get { return _resultRank; }
            set { _resultRank = value; }
        }

        ///<summary>
        ///总得分
        ///</summary>
               [StringLength(32,ErrorMessage = "总得分长度不能超过32")]
        public string ResultPoint
        {
            get { return _resultPoint; }
            set { _resultPoint = value; }
        }

        ///<summary>
        ///评定结果
        ///</summary>
              
        public string ResultText
        {
            get { return _resultText; }
            set { _resultText = value; }
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
        [DBFieldInfo(ColumnName = "PersonReviewResultlnfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _personReviewResultlnfoID;


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
        /// 部门内排名
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultRank", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _resultRank;


		/// <summary>
        /// 总得分
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _resultPoint;


		/// <summary>
        /// 评定结果
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _resultText;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
