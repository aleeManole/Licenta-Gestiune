using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Classes
{
    public class AngajatService : IAngajatService
    {
        public IEnumerable<IdentifAngajFacult_Result> List(int id)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifAngajFacult(id).ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
