namespace SeaSky.NewTempProject.DAL
{
   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSky.StandardLib.MyBaseClass;
using SeaSky.StandardLib.MyModel;
using SeaSky.NewTempProject.Model;

    public interface IDicRepository : IDALBaseNew<DicModel, DicOutputModel, DicViewModel>, IDALPageBaseNew<DicModel, DicOutputModel, DicViewModel>
    {

    }


}

