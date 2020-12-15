namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 部门考核表
    /// </summary>
    [DBTableInfo("tb_OrgehResultInfo")]
    [Serializable]
    public partial class OrgehResultInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? OrgehResultInfoID
        {
            get { return _orgehResultInfoID; }
            set { _orgehResultInfoID = value; }
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
        ///考核部门
        ///</summary>
               [StringLength(32,ErrorMessage = "考核部门长度不能超过32")]
        public string Orgeh
        {
            get { return _orgeh; }
            set { _orgeh = value; }
        }

        ///<summary>
        ///考核部门排名
        ///</summary>
              
        public int? OrgehIndex
        {
            get { return _orgehIndex; }
            set { _orgehIndex = value; }
        }

        ///<summary>
        ///排名排序
        ///</summary>
              
        public int? OrgehIndex2
        {
            get { return _orgehIndex2; }
            set { _orgehIndex2 = value; }
        }

        ///<summary>
        ///考核总得分
        ///</summary>
               [StringLength(32,ErrorMessage = "考核总得分长度不能超过32")]
        public string ResultPoint
        {
            get { return _resultPoint; }
            set { _resultPoint = value; }
        }

        ///<summary>
        ///考核系数
        ///</summary>
               [StringLength(32,ErrorMessage = "考核系数长度不能超过32")]
        public string ResultModulus
        {
            get { return _resultModulus; }
            set { _resultModulus = value; }
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
        [DBFieldInfo(ColumnName = "OrgehResultInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgehResultInfoID;


		/// <summary>
        /// 考核年度
        /// </summary>
        [DBFieldInfo(ColumnName = "AppraisalsYear", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _appraisalsYear;


		/// <summary>
        /// 考核部门
        /// </summary>
        [DBFieldInfo(ColumnName = "Orgeh", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgeh;


		/// <summary>
        /// 考核部门排名
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehIndex", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _orgehIndex;


		/// <summary>
        /// 排名排序
        /// </summary>
        [DBFieldInfo(ColumnName = "OrgehIndex2", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Int, OrderIndex = -1, OrderAsc = true)]
        protected int? _orgehIndex2;


		/// <summary>
        /// 考核总得分
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultPoint", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _resultPoint;


		/// <summary>
        /// 考核系数
        /// </summary>
        [DBFieldInfo(ColumnName = "ResultModulus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _resultModulus;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
