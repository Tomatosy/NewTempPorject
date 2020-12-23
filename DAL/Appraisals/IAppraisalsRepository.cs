namespace SeaSky.PersonnelPerformance.DAL
{
   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomato.StandardLib.MyBaseClass;
using Tomato.StandardLib.MyModel;
using SeaSky.PersonnelPerformance.Model;

    public interface IAppraisalsRepository : IDALBaseNew<AppraisalsModel, AppraisalsOutputModel, AppraisalsViewModel>, IDALPageBaseNew<AppraisalsModel, AppraisalsOutputModel, AppraisalsViewModel>
    {

    }


}

