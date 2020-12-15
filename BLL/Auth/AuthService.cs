namespace Tomato.NewTempProject.BLL
{
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Practices.Unity;
using System.Transactions;
using Newtonsoft.Json;
using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.Model;
using Tomato.NewTempProject.Model.Enum;
using Tomato.NewTempProject.DAL;
using Tomato.StandardLib.MyExtensions;

    public class AuthService : IAuthService
    {
        [Dependency]
        public IAuthRepository AuthRepository { get; set; }


        #region 基础方法
        /// <summary>
        /// 获取用户权限表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<AuthViewModel>> ListViewPageAuth(AuthViewModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new AuthViewModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                model.IsDelete = false;
                // 开启查询outModel里面的视图
                using (this.AuthRepository.BeginSelView())
                {
                  using (this.AuthRepository.BeginLikeMode())
                  {
                      return new SuccessResultModel<PageModel<AuthViewModel>>(this.AuthRepository.ListViewPage(model));
                  }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListViewPageAuth", JsonConvert.SerializeObject(model), "Auth", "获取用户权限表视图列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<AuthViewModel>>(EnumErrorCode.系统异常, "获取用户权限表视图列表分页查询数据时发生错误!");
            }
        }
		
        /// <summary>
        /// 获取用户权限表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<AuthOutputModel>> ListPageAuth(AuthInputModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new AuthInputModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                model.IsDelete = false;
                using (this.AuthRepository.BeginLikeMode())
                {
                    return new SuccessResultModel<PageModel<AuthOutputModel>>(this.AuthRepository.ListPage(model));
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListPageAuth", JsonConvert.SerializeObject(model), "Auth", "获取用户权限表列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<AuthOutputModel>>(EnumErrorCode.系统异常, "获取用户权限表列表分页查询数据时发生错误!");
            }
        }

        /// <summary>
        /// 新增、修改用户权限表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<AuthOutputModel> ModifyAuth(AuthInputModel model)
        {
            SuccessResultModel<AuthOutputModel> result = new SuccessResultModel<AuthOutputModel>();
            ErrorResultModel<AuthOutputModel> error = new ErrorResultModel<AuthOutputModel>();
            try
            {
                if (model.AuthID.IsNullOrEmpty())
                {
                    result.Data = this.AuthRepository.InsertAndReturn(model);
                }
                else
                {
                    result.Data = this.AuthRepository.UpdateWithKeysAndReturn(model);
                }
                return result;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ModifyAuth", JsonConvert.SerializeObject(model), "Auth", "新增、修改用户权限表异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "新增、修改用户权限表异常!";
                return error;
            }
        }

        /// <summary>
        /// 删除用户权限表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public BaseResultModel<int> DeleteAuth(List<Guid?> IDs)
        {
            SuccessResultModel<int> result = new SuccessResultModel<int>();
            ErrorResultModel<int> error = new ErrorResultModel<int>();
            try
            {
                List<AuthInputModel> delList = new List<AuthInputModel>();
                foreach (Guid? item in IDs)
                {
                    delList.Add(new AuthInputModel()
                    {
                        AuthID = item,
                        IsDelete = true
                    });
                }
                result.Data = this.AuthRepository.UpdateWithKeys(delList.ToArray());

                if(result.Data==0)
                {
                    error.ErrorCode=EnumErrorCode.业务执行失败;
                    error.ErrorMessage="请确认需要删除的数据！";
                    return error;
                }
                return result;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "DeleteAuth", JsonConvert.SerializeObject(IDs), "Auth", "删除用户权限表 (逻辑删除)异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "删除用户权限表 (逻辑删除)异常!";
                return error;
            }
        }

        /// <summary>
        /// 获取单个用户权限表
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public BaseResultModel<AuthViewModel> GetAuth(Guid? ID)
        {
            try
            {
                // 开启查询outModel里面的视图
                using (this.AuthRepository.BeginSelView())
                {
                    using (this.AuthRepository.BeginLikeMode())
                    {
                      return new SuccessResultModel<AuthViewModel>(
                          this.AuthRepository.SelectWithViewModel(new AuthViewModel()
                          {
                              AuthID = ID
                          }
                      ));
                    }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "GetAuth", ID+ string.Empty, "Auth", "获取单个用户权限表异常", e);
                return new ErrorResultModel<AuthViewModel>(EnumErrorCode.系统异常, "获取单个用户权限表异常!");
            }
        }
        #endregion
    }
}
