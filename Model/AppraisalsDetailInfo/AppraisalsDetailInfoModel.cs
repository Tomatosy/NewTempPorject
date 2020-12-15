namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 工作量情况统计明细表
    /// </summary>
    [DBTableInfo("tb_AppraisalsDetailInfo")]
    [Serializable]
    public partial class AppraisalsDetailInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? AppraisalsDetailInfoID
        {
            get { return _appraisalsDetailInfoID; }
            set { _appraisalsDetailInfoID = value; }
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
        ///考核项目ID
        ///</summary>
              
        public Guid? AppraisalsID
        {
            get { return _appraisalsID; }
            set { _appraisalsID = value; }
        }

        ///<summary>
        ///考核项目得分（通过计分规则从工作量系统表中获取计算得到）
        ///</summary>
               [StringLength(50,ErrorMessage = "考核项目得分（通过计分规则从工作量系统表中获取计算得到）长度不能超过50")]
        public string AppraisalsPoint
        {
            get { return _appraisalsPoint; }
            set { _appraisalsPoint = value; }
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
        [DBFieldInfo(ColumnName = "AppraisalsDetailInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _appraisalsDetailInfoID;


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
        /// 考核项目ID
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsID", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _appraisalsID;


		/// <summary>
        /// 考核项目得分（通过计分规则从工作量系统表中获取计算得到）
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsPoint;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
