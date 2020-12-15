using Tomato.NewTempProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomato.StandardLib.MyModel;

namespace Tomato.NewTempProject.BLL
{
    public interface ITestService
    {
        BaseResultModel<List<TestOutputModel>> Test(TestInputModel model);

        BaseResultModel<TestOutputModel> CreateData(TestInputModel model);

        BaseResultModel<int> RemoveData(List<TestInputModel> model);
    }
}
