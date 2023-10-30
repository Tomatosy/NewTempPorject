namespace Tomato.NewTempProject.BLL
{
    using System;
    using System.Collections.Generic;
    using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.Model;

    public partial interface IDicService 
    {

        #region 基础方法
        /// <summary>
        /// 获取数据字典表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<DicViewModel>> ListViewPageDic(DicViewModel model);

        /// <summary>
        /// 获取数据字典表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<DicOutputModel>> ListPageDic(DicInputModel model);

        /// <summary>
        /// 新增、修改数据字典表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<DicOutputModel> ModifyDic(DicInputModel model);

        /// <summary>
        /// 删除数据字典表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        BaseResultModel<int> DeleteDic(List<Guid?> IDs);

        /// <summary>
        /// 获取单个数据字典表
        /// </summary>
        BaseResultModel<DicViewModel> GetDic(Guid? ID);

        #endregion  
  }


}
