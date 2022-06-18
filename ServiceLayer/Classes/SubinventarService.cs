using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Attributes;
using Newtonsoft.Json;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Classes
{
    public class SubinventarService : ISubinventarService
    {
       public IEnumerable<ListaSubinv_SP_Result> List()
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.ListaSubinv_SP().ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public long Add(SubinventarAttributes subinventarAttributes)
        {
            try
            {
                //validare
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.InsertSubinv_SP(subinventarAttributes.idSubinventar,
                                                   subinventarAttributes.idStudent,
                                                   subinventarAttributes.idAngajat,
                                                   subinventarAttributes.idDepozit,
                                                   subinventarAttributes.dataPrimire,
                                                   subinventarAttributes.dataPredare,
                                                   subinventarAttributes.idObiect,
                                                   subinventarAttributes.cantitate).ToString().First();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(SubinventarAttributes subinventarAttributes)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    context.UpdateSubinv_SP(subinventarAttributes.idSubinventar,
                                                   subinventarAttributes.idStudent,
                                                   subinventarAttributes.idAngajat,
                                                   subinventarAttributes.idDepozit,
                                                   subinventarAttributes.dataPrimire,
                                                   subinventarAttributes.dataPredare,
                                                   subinventarAttributes.idObiect,
                                                   subinventarAttributes.cantitate).ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long idSubinventar)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    context.DeleteSubinv_SP(idSubinventar);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public IEnumerable<IdentifSubinvObiect_Result> SubinventareByObj(long id)
        {
            try
            {
                using (var context = new gestiuneInventar2Entities())
                {
                    return context.IdentifSubinvObiect(id).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       

       
    }
}
