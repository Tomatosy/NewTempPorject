namespace SeaSky.PersonnelPerformance.Model
{
    using Tomato.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using Tomato.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using Tomato.StandardLib.FrameWork;

	/// <summary>
    /// 部门评分对应表
    /// </summary>
    [DBTableInfo("tb_OrgLeader")]
    [Serializable]
    public partial class OrgLeaderModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? OrgLeaderID
        {
            get { return _orgLeaderID; }
            set { _orgLeaderID = value; }
        }

        ///<summary>
        ///工号
        ///</summary>
        [RequiredAll(ErrorMessage = "工号不能为空")]        [StringLength(50,ErrorMessage = "工号长度不能超过50")]
        public string pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///可评分部门
        ///</summary>
        [RequiredAll(ErrorMessage = "可评分部门不能为空")]        [StringLength(50,ErrorMessage = "可评分部门长度不能超过50")]
        public string Orgeh
        {
            get { return _orgeh; }
            set { _orgeh = value; }
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
        [DBFieldInfo(ColumnName = "OrgLeaderID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgLeaderID;


		/// <summary>
        /// 工号
        /// </summary>
        [DBFieldInfo(ColumnName = "pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 可评分部门
        /// </summary>
        [DBFieldInfo(ColumnName = "Orgeh", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _orgeh;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
