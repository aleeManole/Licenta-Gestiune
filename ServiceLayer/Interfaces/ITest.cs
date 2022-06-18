using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface ITest
    {
        IEnumerable<IdentifAngajFacult_Result> List(int idFacultate);
    }
}
