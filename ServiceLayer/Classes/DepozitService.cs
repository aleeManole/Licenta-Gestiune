using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Classes
{
    public class DepozitService : IDepozitService
    {
        public IEnumerable<ListaDepozite_SP_Result> List()
        {
            try
            {
                using(var context = new gestiuneInventar2Entities())
                {
                    return context.ListaDepozite_SP().ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
