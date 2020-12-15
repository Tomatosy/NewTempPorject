namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 部门考核明细打分表
    /// </summary>
    [DBTableInfo("tb_OrgehResultDetailInfo")]
    [Serializable]
    public partial class OrgehResultDetailInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? OrgehResultDetailInfoID
        {
            get { return _orgehResultDetailInfoID; }
            set { _orgehResultDetailInfoID = value; }
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
        ///考核部门（1个部门多人打分）
        ///</summary>
               [StringLength(64,ErrorMessage = "考核部门（1个部门多人打分）长度不能超过64")]
        public string Orgeh
        {
            get { return _orgeh; }
            set { _orgeh = value; }
        }

        ///<summary>
        ///评分人工号
        ///</summary>
               [StringLength(32,ErrorMessage = "评分人工号长度不能超过32")]
        public string ReviewPernr
        {
            get { return _reviewPernr; }
            set { _reviewPernr = value; }
        }

        ///<summary>
        ///得分
        ///</summary>
               [StringLength(32,ErrorMessage = "得分长度不能超过32")]
        public string ReviewPoint
        {
            get { return _reviewPoint; }
            set { _reviewPoint = value; }
        }

        ///<summary>
        ///评价结果（可选，冗余考核配置表对应文本）
        ///</summary>
               [StringLength(32,ErrorMessage = "评价结果（可选，冗余考核配置表对应文本）长度不能超过32")]
        public string ReviewText
        {
            get { return _reviewText; }
            set { _reviewText = value; }
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
        [DBFieldInfo(ColumnName = "OrgehResultDetailInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgehResultDetailInfoID;


		/// <summary>
        /// 考核年度
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 考核部门（1个部门多人打分）
        /// </summary>
        [DBFieldInfo(ColumnName = "Orgeh", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgeh;


		/// <summary>
        /// 评分人工号
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewPernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewPernr;


		/// <summary>
        /// 得分
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewPoint;


		/// <summary>
        /// 评价结果（可选，冗余考核配置表对应文本）
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewText;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
