using Microsoft.Practices.Unity;
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

    public class AcademicYearController : ApiController
    {

        private IAcademicYearService AcademicYearService = ApplicationContext.Current.UnityContainer.Resolve<IAcademicYearService>();


        #region 基础方法
		
        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model">ViewModel</param>
        /// <returns>ViewModel</returns>
        public BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYear(AcademicYearViewModel model)
        {
            return AcademicYearService.ListViewPageAcademicYear(model);
        }
		
        /// <summary>
        /// 获取学年表列表分页
        /// </summary>
        /// <param name="model">InputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<PageModel<AcademicYearOutputModel>> ListPageAcademicYear(AcademicYearInputModel model)
        {
            return AcademicYearService.ListPageAcademicYear(model);
        }

        /// <summary>
        /// 新增、修改学年表
        /// </summary>
        /// <param name="model">OutputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<AcademicYearOutputModel> ModifyAcademicYear(AcademicYearInputModel model)
        {
            if (model == null)
            {
                return new ErrorResultModel<AcademicYearOutputModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            ModelAttrEx arrtEx = new ModelAttrEx();
            string modelErrorMes = "";
            if (model.AcademicYearID.IsNullOrEmpty())
            {
                modelErrorMes += arrtEx.AddAttrVaild<AcademicYearInputModel>(ModelState, model);
            }
            else
            {
                modelErrorMes += arrtEx.EditAttrVaild<AcademicYearInputModel>(ModelState, model);
            }
            if (!modelErrorMes.IsNullOrEmpty())
            {
                return new ErrorResultModel<AcademicYearOutputModel>(EnumErrorCode.请求参数错误, modelErrorMes);
            }
            return AcademicYearService.ModifyAcademicYear(model);
        }

        /// <summary>
        /// 删除学年表 (逻辑删除)
        /// </summary>
        /// <param name="IDs">List-->Guid?</param>
        /// <returns>受影响行数</returns>
        [HttpPost]
        public BaseResultModel<int> DeleteAcademicYear(List<Guid?> IDs)
        {
            if (IDs==null||IDs.Count == 0)
            {
                return new ErrorResultModel<int>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return AcademicYearService.DeleteAcademicYear(IDs);
        }

        /// <summary>
        /// 获取单个学年表
        /// </summary>
        /// <param name="ID">Guid?</param>
        /// <returns>ViewModel</returns>
        [HttpPost]
        public BaseResultModel<AcademicYearViewModel> GetAcademicYear(Guid? ID)
        {
            if (ID.IsNullOrEmpty())
            {
                return new ErrorResultModel<AcademicYearViewModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return AcademicYearService.GetAcademicYear(ID);
        }
        #endregion
    }


}
