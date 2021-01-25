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

    public partial class AcademicYearController : ApiController
    {




        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model">ViewModel</param>
        /// <returns>ViewModel</returns>
        public BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYearAAA(AcademicYearViewModel model)
        {
            return AcademicYearService.ListViewPageAcademicYearAAA(model);
        }

    }


}
