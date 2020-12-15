namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 服务对象评分表
    /// </summary>
    [DBTableInfo("tb_ServiceReviewInfo")]
    [Serializable]
    public partial class ServiceReviewInfoModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? ServiceReviewInfoID
        {
            get { return _serviceReviewInfoID; }
            set { _serviceReviewInfoID = value; }
        }

        ///<summary>
        ///主键编号
        ///</summary>
               [StringLength(50,ErrorMessage = "主键编号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///项目名称
        ///</summary>
               [StringLength(50,ErrorMessage = "项目名称长度不能超过50")]
        public string Modulus
        {
            get { return _modulus; }
            set { _modulus = value; }
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
        [DBFieldInfo(ColumnName = "ServiceReviewInfoID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _serviceReviewInfoID;


		/// <summary>
        /// 主键编号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 项目名称
        /// </summary>
        [DBFieldInfo(ColumnName = "Modulus", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _modulus;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
