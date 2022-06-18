using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Classes
{
    public class Test : ITest
    {
        public IEnumerable<IdentifAngajFacult_Result> List(int idFacultate)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifAngajFacult(idFacultate).ToList();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
