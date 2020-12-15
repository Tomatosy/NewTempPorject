using Tomato.NewTempProject.Model;
using Tomato.StandardLib.MyBaseClass;
using Tomato.NewTempProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomato.StandardLib.MyModel;

namespace Tomato.NewTempProject.DAL
{
    public interface ITestTableRepository: IDALBase<TestModel,TestOutputModel>, IDALPageBase<TestModel, TestOutputModel>
    {
        PageModel<TestOutputModel> ListPage(TestInputModel model);
    }
}
