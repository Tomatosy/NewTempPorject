namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 超、扣减工作量津贴计算表
    /// </summary>
    [DBTableInfo("tb_TeacherBounsInfo")]
    [Serializable]
    public partial class TeacherBounsInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? TeacherBounsInfoID
        {
            get { return _teacherBounsInfoID; }
            set { _teacherBounsInfoID = value; }
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
        ///工号
        ///</summary>
               [StringLength(50,ErrorMessage = "工号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///需扣津贴的教学分差额
        ///</summary>
               [StringLength(50,ErrorMessage = "需扣津贴的教学分差额长度不能超过50")]
        public string ReducePoint
        {
            get { return _reducePoint; }
            set { _reducePoint = value; }
        }

        ///<summary>
        ///需奖励的教学分差额
        ///</summary>
               [StringLength(50,ErrorMessage = "需奖励的教学分差额长度不能超过50")]
        public string PlusPoint
        {
            get { return _plusPoint; }
            set { _plusPoint = value; }
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
        [DBFieldInfo(ColumnName = "TeacherBounsInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _teacherBounsInfoID;


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
        /// 需扣津贴的教学分差额
        /// </summary>
        [DBFieldInfo(ColumnName = "ReducePoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _reducePoint;


		/// <summary>
        /// 需奖励的教学分差额
        /// </summary>
        [DBFieldInfo(ColumnName = "PlusPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _plusPoint;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
