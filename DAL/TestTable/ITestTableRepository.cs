using SeaSky.NewTempProject.Model;
using SeaSky.StandardLib.MyBaseClass;
using SeaSky.NewTempProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSky.StandardLib.MyModel;

namespace SeaSky.NewTempProject.DAL
{
    public interface ITestTableRepository: IDALBase<TestModel,TestOutputModel>, IDALPageBase<TestModel, TestOutputModel>
    {
        PageModel<TestOutputModel> ListPage(TestInputModel model);
    }
}
