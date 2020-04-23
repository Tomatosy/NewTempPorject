namespace SeaSky.NewTempProject.Model
{
    using SeaSky.StandardLib.MyAttribute;
    using System;
    using System.Data;
    using SeaSky.StandardLib.MyModel;
    using System.ComponentModel.DataAnnotations;
    using SeaSky.StandardLib.FrameWork;

	/// <summary>
    /// 用户权限表
    /// </summary>
    [DBTableInfo("tb_Auth")]
    [Serializable]
    public partial class AuthModel : BasePageModel
    {


        ///<summary>
        ///主键ID
        ///</summary>
              
        public Guid? AuthID
        {
            get { return _authID; }
            set { _authID = value; }
        }

        ///<summary>
        ///工号
        ///</summary>
        [RequiredAll(ErrorMessage = "工号不能为空")]        [StringLength(50,ErrorMessage = "工号长度不能超过50")]
        public string Pernr
        {
            get { return _pernr; }
            set { _pernr = value; }
        }

        ///<summary>
        ///部门ID
        ///</summary>
        [RequiredAll(ErrorMessage = "部门ID不能为空")]       
        public Guid? Orgeh
        {
            get { return _orgeh; }
            set { _orgeh = value; }
        }

        ///<summary>
        ///角色ID（多角色，多行）
        ///</summary>
        [RequiredAll(ErrorMessage = "角色ID（多角色，多行）不能为空")]       
        public Guid? RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
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
        [DBFieldInfo(ColumnName = "AuthID", IsIdentity = false, 
IsKey = true, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _authID;


		/// <summary>
        /// 工号
        /// </summary>
        [DBFieldInfo(ColumnName = "Pernr", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.NVarChar, OrderIndex = -1, OrderAsc = true, LikeEqual = EnumLikeMode.AllLike)]
        protected string _pernr;


		/// <summary>
        /// 部门ID
        /// </summary>
        [DBFieldInfo(ColumnName = "Orgeh", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _orgeh;


		/// <summary>
        /// 角色ID（多角色，多行）
        /// </summary>
        [DBFieldInfo(ColumnName = "RoleID", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.UniqueIdentifier, OrderIndex = -1, OrderAsc = true)]
        protected Guid? _roleID;


		/// <summary>
        /// 是否删除
        /// </summary>
        [DBFieldInfo(ColumnName = "IsDelete", IsIdentity = false, 
IsKey = false, SqlDbType =SqlDbType.Bit, OrderIndex = -1, OrderAsc = true)]
        protected bool? _isDelete=false;


        #endregion

          }
}
