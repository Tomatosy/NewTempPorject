namespace Tomato.NewTempProject.BLL
{
    using System;
    using System.Collections.Generic;
    using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.Model;

    public interface IAuthService 
    {

        #region 基础方法
        /// <summary>
        /// 获取用户权限表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<AuthViewModel>> ListViewPageAuth(AuthViewModel model);

        /// <summary>
        /// 获取用户权限表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<AuthOutputModel>> ListPageAuth(AuthInputModel model);

        /// <summary>
        /// 新增、修改用户权限表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<AuthOutputModel> ModifyAuth(AuthInputModel model);

        /// <summary>
        /// 删除用户权限表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        BaseResultModel<int> DeleteAuth(List<Guid?> IDs);

        /// <summary>
        /// 获取单个用户权限表
        /// </summary>
        BaseResultModel<AuthViewModel> GetAuth(Guid? ID);

        #endregion  
  }


}
