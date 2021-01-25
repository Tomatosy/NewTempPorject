namespace Tomato.NewTempProject.BLL
{
    using System;
    using System.Collections.Generic;
    using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.Model;

    public partial interface IAcademicYearService 
    {

        #region 基础方法
        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYear(AcademicYearViewModel model);

        /// <summary>
        /// 获取学年表列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<AcademicYearOutputModel>> ListPageAcademicYear(AcademicYearInputModel model);

        /// <summary>
        /// 新增、修改学年表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<AcademicYearOutputModel> ModifyAcademicYear(AcademicYearInputModel model);

        /// <summary>
        /// 删除学年表 (逻辑删除)
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        BaseResultModel<int> DeleteAcademicYear(List<Guid?> IDs);

        /// <summary>
        /// 获取单个学年表
        /// </summary>
        BaseResultModel<AcademicYearViewModel> GetAcademicYear(Guid? ID);

        #endregion  
  }


}
