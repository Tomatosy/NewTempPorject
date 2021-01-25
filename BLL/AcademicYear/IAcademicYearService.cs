namespace Tomato.NewTempProject.BLL
{
    using System;
    using System.Collections.Generic;
    using Tomato.StandardLib.MyModel;
    using Tomato.NewTempProject.Model;

    public partial interface IAcademicYearService
    {
        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYearAAA(AcademicYearViewModel model);
    }


}
