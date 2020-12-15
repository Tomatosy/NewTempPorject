namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 部门主管打分表
    /// </summary>
    [DBTableInfo("tb_OrgerLeaderReviewInfo")]
    [Serializable]
    public partial class OrgerLeaderReviewInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? OrgerLeaderReviewInfoID
        {
            get { return _orgerLeaderReviewInfoID; }
            set { _orgerLeaderReviewInfoID = value; }
        }

        ///<summary>
        ///被评价人工号
        ///</summary>
               [StringLength(50,ErrorMessage = "被评价人工号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///得分
        ///</summary>
               [StringLength(50,ErrorMessage = "得分长度不能超过50")]
        public string Point
        {
            get { return _point; }
            set { _point = value; }
        }

        ///<summary>
        ///评分人
        ///</summary>
               [StringLength(50,ErrorMessage = "评分人长度不能超过50")]
        public string ReviewUser
        {
            get { return _reviewUser; }
            set { _reviewUser = value; }
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
        [DBFieldInfo(ColumnName = "OrgerLeaderReviewInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgerLeaderReviewInfoID;


		/// <summary>
        /// 被评价人工号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 得分
        /// </summary>
        [DBFieldInfo(ColumnName = "Point", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _point;


		/// <summary>
        /// 评分人
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewUser", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewUser;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
