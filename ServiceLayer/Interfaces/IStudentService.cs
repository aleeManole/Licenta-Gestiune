using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<IdentifStudentFacult_SP_Result> List(int id);
        IdentifStudentCnp_SP_Result StudentByCNP(string cnp);
    }
}
