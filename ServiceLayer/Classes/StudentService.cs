using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Classes
{
    public class StudentService : IStudentService
    {
        public IEnumerable<IdentifStudentFacult_SP_Result> List(int id)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifStudentFacult_SP(id).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public IdentifStudentCnp_SP_Result StudentByCNP(string cnp)
        {
            try
            {
                using(var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifStudentCnp_SP(cnp).First();
                }
            }
            catch(Exception)
            {
                throw;
            }
           
        }
    }
        




}
