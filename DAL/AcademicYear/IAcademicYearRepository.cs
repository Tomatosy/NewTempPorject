namespace Tomato.NewTempProject.DAL
{
   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomato.StandardLib.MyBaseClass;
using Tomato.StandardLib.MyModel;
using Tomato.NewTempProject.Model;

    public interface IAcademicYearRepository : IDALBaseNew<AcademicYearModel, AcademicYearOutputModel, AcademicYearViewModel>, IDALPageBaseNew<AcademicYearModel, AcademicYearOutputModel, AcademicYearViewModel>
    {

    }


}

