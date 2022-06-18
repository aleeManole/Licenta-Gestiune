using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;
using System.Data.Entity;


namespace ServiceLayer.Classes
{
   public class GestionarService : IGestionarService
    {
        public Gestionar GetGestionarFacultate(short idFacultate)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.GestionarPeFacultate(idFacultate).First();
                }
            }
            catch(Exception )
            {
                throw;
            }
        }

        public IEnumerable<ListaGestionariFacultate_SP_Result> List()
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.ListaGestionariFacultate_SP().ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
