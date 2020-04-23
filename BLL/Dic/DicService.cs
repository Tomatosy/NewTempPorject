namespace SeaSky.NewTempProject.BLL
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
using SeaSky.StandardLib.MyModel;
using SeaSky.NewTempProject.Model;
using SeaSky.NewTempProject.Model.Enum;
using SeaSky.NewTempProject.DAL;
using SeaSky.StandardLib.MyExtensions;

    public class DicService : IDicService
    {
        [Dependency]
        public IDicRepository DicRepository { get; set; }


        #region 基础方法
        /// <summary>
        /// 获取数据字典表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<DicViewModel>> ListViewPageDic(DicViewModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new DicViewModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                model.IsDelete = false;
                // 开启查询outModel里面的视图
                using (this.DicRepository.BeginSelView())
                {
                  using (this.DicRepository.BeginLikeMode())
                  {
                      return new SuccessResultModel<PageModel<DicViewModel>>(this.DicRepository.ListViewPage(model));
                  }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListViewPageDic", JsonConvert.SerializeObject(model), "Dic", "获取数据字典表视图列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<DicViewModel>>(EnumErrorCode.系统异常, "获取数据字典表视图列表分页查询数据时发生错误!");
            }
        }
		
        /// <summary>
        /// 获取数据字典表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<DicOutputModel>> ListPageDic(DicInputModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new DicInputModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                model.IsDelete = false;
                using (this.DicRepository.BeginLikeMode())
                {
                    return new SuccessResultModel<PageModel<DicOutputModel>>(this.DicRepository.ListPage(model));
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListPageDic", JsonConvert.SerializeObject(model), "Dic", "获取数据字典表列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<DicOutputModel>>(EnumErrorCode.系统异常, "获取数据字典表列表分页查询数据时发生错误!");
            }
        }

        /// <summary>
        /// 新增、修改数据字典表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<DicOutputModel> ModifyDic(DicInputModel model)
        {
            SuccessResultModel<DicOutputModel> result = new SuccessResultModel<DicOutputModel>();
            ErrorResultModel<DicOutputModel> error = new ErrorResultModel<DicOutputModel>();
            try
            {
                if (model.DicID.IsNullOrEmpty())
                {
                    result.Data = this.DicRepository.InsertAndReturn(model);
                }
                else
                {
                    result.Data = this.DicRepository.UpdateWithKeysAndReturn(model);
                }
                return result;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ModifyDic", JsonConvert.SerializeObject(model), "Dic", "新增、修改数据字典表异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "新增、修改数据字典表异常!";
                return error;
            }
        }

        /// <summary>
        /// 删除数据字典表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public BaseResultModel<int> DeleteDic(List<Guid?> IDs)
        {
            SuccessResultModel<int> result = new SuccessResultModel<int>();
            ErrorResultModel<int> error = new ErrorResultModel<int>();
            try
            {
                List<DicInputModel> delList = new List<DicInputModel>();
                foreach (Guid? item in IDs)
                {
                    delList.Add(new DicInputModel()
                    {
                        DicID = item,
                        IsDelete = true
                    });
                }
                result.Data = this.DicRepository.UpdateWithKeys(delList.ToArray());

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
                LogWriter.WriteLog(EnumLogLevel.Fatal, "DeleteDic", JsonConvert.SerializeObject(IDs), "Dic", "删除数据字典表 (逻辑删除)异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "删除数据字典表 (逻辑删除)异常!";
                return error;
            }
        }

        /// <summary>
        /// 获取单个数据字典表
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public BaseResultModel<DicViewModel> GetDic(Guid? ID)
        {
            try
            {
                // 开启查询outModel里面的视图
                using (this.DicRepository.BeginSelView())
                {
                    using (this.DicRepository.BeginLikeMode())
                    {
                      return new SuccessResultModel<DicViewModel>(
                          this.DicRepository.SelectWithViewModel(new DicViewModel()
                          {
                              DicID = ID
                          }
                      ));
                    }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "GetDic", ID+ string.Empty, "Dic", "获取单个数据字典表异常", e);
                return new ErrorResultModel<DicViewModel>(EnumErrorCode.系统异常, "获取单个数据字典表异常!");
            }
        }
        #endregion
    }
}
