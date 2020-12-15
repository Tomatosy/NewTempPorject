namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 格式配置表
    /// </summary>
    [DBTableInfo("tb_PersonReview")]
    [Serializable]
    public partial class PersonReviewModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? PersonReviewID
        {
            get { return _personReviewID; }
            set { _personReviewID = value; }
        }

        ///<summary>
        ///序号
        ///</summary>
               [StringLength(32,ErrorMessage = "序号长度不能超过32")]
        public string TbIndex
        {
            get { return _tbIndex; }
            set { _tbIndex = value; }
        }

        ///<summary>
        ///考核项目
        ///</summary>
               [StringLength(32,ErrorMessage = "考核项目长度不能超过32")]
        public string ReviewProject
        {
            get { return _reviewProject; }
            set { _reviewProject = value; }
        }

        ///<summary>
        ///考核内容与要求
        ///</summary>
               [StringLength(128,ErrorMessage = "考核内容与要求长度不能超过128")]
        public string ReviewText
        {
            get { return _reviewText; }
            set { _reviewText = value; }
        }

        ///<summary>
        ///最高分值
        ///</summary>
               [StringLength(32,ErrorMessage = "最高分值长度不能超过32")]
        public string ReviewPoint
        {
            get { return _reviewPoint; }
            set { _reviewPoint = value; }
        }

        ///<summary>
        ///考核办法
        ///</summary>
               [StringLength(128,ErrorMessage = "考核办法长度不能超过128")]
        public string ReviewRule
        {
            get { return _reviewRule; }
            set { _reviewRule = value; }
        }

        ///<summary>
        ///备注
        ///</summary>
              
        public string ReviewMemo
        {
            get { return _reviewMemo; }
            set { _reviewMemo = value; }
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
        [DBFieldInfo(ColumnName = "PersonReviewID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _personReviewID;


		/// <summary>
        /// 序号
        /// </summary>
        [DBFieldInfo(ColumnName = "TbIndex", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _tbIndex;


		/// <summary>
        /// 考核项目
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewProject", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewProject;


		/// <summary>
        /// 考核内容与要求
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewText", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewText;


		/// <summary>
        /// 最高分值
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewPoint;


		/// <summary>
        /// 考核办法
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewRule", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewRule;


		/// <summary>
        /// 备注
        /// </summary>
        [DBFieldInfo(ColumnName = "ReviewMemo", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reviewMemo;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
