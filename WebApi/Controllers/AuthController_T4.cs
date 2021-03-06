﻿using Microsoft.Practices.Unity;
using Tomato.StandardLib.MyModel;
using System.Collections.Generic;
using System.Web.Http;
using Tomato.NewTempProject.BLL;
using Tomato.NewTempProject.Model;
using System;
using Tomato.NewTempProject.WebApi.Log;
using System.Net.Http;
using Tomato.StandardLib.MyExtensions;
namespace Tomato.NewTempProject.WebApi.Controllers
{

    public partial class AuthController : ApiController
    {

        private IAuthService AuthService = ApplicationContext.Current.UnityContainer.Resolve<IAuthService>();


        #region 基础方法
		
        /// <summary>
        /// 获取用户权限表视图列表分页
        /// </summary>
        /// <param name="model">ViewModel</param>
        /// <returns>ViewModel</returns>
        public BaseResultModel<PageModel<AuthViewModel>> ListViewPageAuth(AuthViewModel model)
        {
            return AuthService.ListViewPageAuth(model);
        }
		
        /// <summary>
        /// 获取用户权限表列表分页
        /// </summary>
        /// <param name="model">InputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<PageModel<AuthOutputModel>> ListPageAuth(AuthInputModel model)
        {
            return AuthService.ListPageAuth(model);
        }

        /// <summary>
        /// 新增、修改用户权限表
        /// </summary>
        /// <param name="model">OutputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<AuthOutputModel> ModifyAuth(AuthInputModel model)
        {
            if (model == null)
            {
                return new ErrorResultModel<AuthOutputModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            ModelAttrEx arrtEx = new ModelAttrEx();
            string modelErrorMes = "";
            if (model.AuthID.IsNullOrEmpty())
            {
                modelErrorMes += arrtEx.AddAttrVaild<AuthInputModel>(ModelState, model);
            }
            else
            {
                modelErrorMes += arrtEx.EditAttrVaild<AuthInputModel>(ModelState, model);
            }
            if (!modelErrorMes.IsNullOrEmpty())
            {
                return new ErrorResultModel<AuthOutputModel>(EnumErrorCode.请求参数错误, modelErrorMes);
            }
            return AuthService.ModifyAuth(model);
        }

        /// <summary>
        /// 删除用户权限表 (逻辑删除)
        /// </summary>
        /// <param name="IDs">List-->Guid?</param>
        /// <returns>受影响行数</returns>
        [HttpPost]
        public BaseResultModel<int> DeleteAuth(List<Guid?> IDs)
        {
            if (IDs==null||IDs.Count == 0)
            {
                return new ErrorResultModel<int>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return AuthService.DeleteAuth(IDs);
        }

        /// <summary>
        /// 获取单个用户权限表
        /// </summary>
        /// <param name="ID">Guid?</param>
        /// <returns>ViewModel</returns>
        [HttpPost]
        public BaseResultModel<AuthViewModel> GetAuth(Guid? ID)
        {
            if (ID.IsNullOrEmpty())
            {
                return new ErrorResultModel<AuthViewModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return AuthService.GetAuth(ID);
        }
        #endregion
    }


}
