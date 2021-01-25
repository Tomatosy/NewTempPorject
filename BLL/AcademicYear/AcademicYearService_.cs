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

        /// <summary>
        /// 获取学年表视图列表分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResultModel<PageModel<AcademicYearViewModel>> ListViewPageAcademicYearAAA(AcademicYearViewModel model)
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
    }
}
