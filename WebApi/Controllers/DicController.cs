using Microsoft.Practices.Unity;
using SeaSky.StandardLib.MyModel;
using System.Collections.Generic;
using System.Web.Http;
using SeaSky.NewTempProject.BLL;
using SeaSky.NewTempProject.Model;
using System;
using SeaSky.NewTempProject.WebApi.Log;
using System.Net.Http;
using SeaSky.StandardLib.MyExtensions;
namespace SeaSky.NewTempProject.WebApi.Controllers
{

    public class DicController : ApiController
    {

        private IDicService DicService = ApplicationContext.Current.UnityContainer.Resolve<IDicService>();


        #region 基础方法
		
        /// <summary>
        /// 获取数据字典表视图列表分页
        /// </summary>
        /// <param name="model">ViewModel</param>
        /// <returns>ViewModel</returns>
        public BaseResultModel<PageModel<DicViewModel>> ListViewPageDic(DicViewModel model)
        {
            return DicService.ListViewPageDic(model);
        }
		
        /// <summary>
        /// 获取数据字典表列表分页
        /// </summary>
        /// <param name="model">InputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<PageModel<DicOutputModel>> ListPageDic(DicInputModel model)
        {
            return DicService.ListPageDic(model);
        }

        /// <summary>
        /// 新增、修改数据字典表
        /// </summary>
        /// <param name="model">OutputModel</param>
        /// <returns>OutputModel</returns>
        public BaseResultModel<DicOutputModel> ModifyDic(DicInputModel model)
        {
            if (model == null)
            {
                return new ErrorResultModel<DicOutputModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            ModelAttrEx arrtEx = new ModelAttrEx();
            string modelErrorMes = "";
            if (model.DicID.IsNullOrEmpty())
            {
                modelErrorMes += arrtEx.AddAttrVaild<DicInputModel>(ModelState, model);
            }
            else
            {
                modelErrorMes += arrtEx.EditAttrVaild<DicInputModel>(ModelState, model);
            }
            if (!modelErrorMes.IsNullOrEmpty())
            {
                return new ErrorResultModel<DicOutputModel>(EnumErrorCode.请求参数错误, modelErrorMes);
            }
            return DicService.ModifyDic(model);
        }

        /// <summary>
        /// 删除数据字典表 (逻辑删除)
        /// </summary>
        /// <param name="IDs">List-->Guid?</param>
        /// <returns>受影响行数</returns>
        [HttpPost]
        public BaseResultModel<int> DeleteDic(List<Guid?> IDs)
        {
            if (IDs==null||IDs.Count == 0)
            {
                return new ErrorResultModel<int>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return DicService.DeleteDic(IDs);
        }

        /// <summary>
        /// 获取单个数据字典表
        /// </summary>
        /// <param name="ID">Guid?</param>
        /// <returns>ViewModel</returns>
        [HttpPost]
        public BaseResultModel<DicViewModel> GetDic(Guid? ID)
        {
            if (ID.IsNullOrEmpty())
            {
                return new ErrorResultModel<DicViewModel>(EnumErrorCode.请求参数错误, "参数不能为空");
            }
            return DicService.GetDic(ID);
        }
        #endregion
    }


}
