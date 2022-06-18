using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Classes
{
    public class ObiectService : IObiectService
    {
        public long Add(long idObiect, string nume, string categorie)
        {
            try
            {
                //validare
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.InsertObj_SP(idObiect, nume, categorie).ToString().First();
                }
            }
            catch(Exception )
            {
                throw;
            }
        }

        public void Update(long idObiect, string nume, string categorie)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    context.UpdateObj_SP(idObiect, nume, categorie).ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long idObiect)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    context.DeleteObj_SP(idObiect);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IEnumerable<IdentifObiectNume_SP_Result> GetObiectByNume(string nume)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifObiectNume_SP(nume).ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IEnumerable<ListaObiecte_SP_Result> List()
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.ListaObiecte_SP().ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
            
        }

       
    }
}
