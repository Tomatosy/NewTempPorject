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

    public partial class AcademicYearService : IAcademicYearService
    {
        [Dependency]
        public IAcademicYearRepository AcademicYearRepository { get; set; }


        #region 基础方法
        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYear(AcademicYearViewModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new AcademicYearViewModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                // 开启查询outModel里面的视图
                using (this.AcademicYearRepository.BeginSelView())
                {
                  using (this.AcademicYearRepository.BeginLikeMode())
                  {
                      return new SuccessResultModel<PageModel<AcademicYearViewModel>>(this.AcademicYearRepository.ListViewPage(model));
                  }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListViewPageAcademicYear", JsonConvert.SerializeObject(model), "AcademicYear", "获取学年表视图列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<AcademicYearViewModel>>(EnumErrorCode.系统异常, "获取学年表视图列表分页查询数据时发生错误!");
            }
        }
		
        /// <summary>
        /// 获取学年表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<AcademicYearOutputModel>> ListPageAcademicYear(AcademicYearInputModel model)
        {
            try
            {
                if (model == null)
                {
                    model = new AcademicYearInputModel()
                    {
                        PageNO = 1,
                        PageSize = int.MaxValue
                    };
                }
                model.IsDelete = false;
                using (this.AcademicYearRepository.BeginLikeMode())
                {
                    return new SuccessResultModel<PageModel<AcademicYearOutputModel>>(this.AcademicYearRepository.ListPage(model));
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ListPageAcademicYear", JsonConvert.SerializeObject(model), "AcademicYear", "获取学年表列表分页查询数据时发生错误.", e);
                return new ErrorResultModel<PageModel<AcademicYearOutputModel>>(EnumErrorCode.系统异常, "获取学年表列表分页查询数据时发生错误!");
            }
        }

        /// <summary>
        /// 新增、修改学年表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<AcademicYearOutputModel> ModifyAcademicYear(AcademicYearInputModel model)
        {
            SuccessResultModel<AcademicYearOutputModel> result = new SuccessResultModel<AcademicYearOutputModel>();
            ErrorResultModel<AcademicYearOutputModel> error = new ErrorResultModel<AcademicYearOutputModel>();
            try
            {
                if (model.AcademicYearID.IsNullOrEmpty())
                {
                    result.Data = this.AcademicYearRepository.InsertAndReturn(model);
                }
                else
                {
                    result.Data = this.AcademicYearRepository.UpdateWithKeysAndReturn(model);
                }
                return result;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "ModifyAcademicYear", JsonConvert.SerializeObject(model), "AcademicYear", "新增、修改学年表异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "新增、修改学年表异常!";
                return error;
            }
        }

        /// <summary>
        /// 删除学年表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public BaseResultModel<int> DeleteAcademicYear(List<Guid?> IDs)
        {
            SuccessResultModel<int> result = new SuccessResultModel<int>();
            ErrorResultModel<int> error = new ErrorResultModel<int>();
            try
            {
                List<AcademicYearInputModel> delList = new List<AcademicYearInputModel>();
                foreach (Guid? item in IDs)
                {
                    delList.Add(new AcademicYearInputModel()
                    {
                        AcademicYearID = item,
                        IsDelete = true
                    });
                }
                result.Data = this.AcademicYearRepository.UpdateWithKeys(delList.ToArray());

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
                LogWriter.WriteLog(EnumLogLevel.Fatal, "DeleteAcademicYear", JsonConvert.SerializeObject(IDs), "AcademicYear", "删除学年表 (逻辑删除)异常！", ex);
                error.ErrorCode = EnumErrorCode.系统异常;
                error.ErrorMessage = "删除学年表 (逻辑删除)异常!";
                return error;
            }
        }

        /// <summary>
        /// 获取单个学年表
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public BaseResultModel<AcademicYearViewModel> GetAcademicYear(Guid? ID)
        {
            try
            {
                // 开启查询outModel里面的视图
                using (this.AcademicYearRepository.BeginSelView())
                {
                    using (this.AcademicYearRepository.BeginLikeMode())
                    {
                      return new SuccessResultModel<AcademicYearViewModel>(
                          this.AcademicYearRepository.SelectWithViewModel(new AcademicYearViewModel()
                          {
                              AcademicYearID = ID
                          }
                      ));
                    }
                }
            }
            catch (Exception e)
            {
                LogWriter.WriteLog(EnumLogLevel.Fatal, "GetAcademicYear", ID+ string.Empty, "AcademicYear", "获取单个学年表异常", e);
                return new ErrorResultModel<AcademicYearViewModel>(EnumErrorCode.系统异常, "获取单个学年表异常!");
            }
        }
        #endregion
    }
}
