using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
   public interface IObiectService
    {
        IEnumerable<ListaObiecte_SP_Result> List();
        IEnumerable<IdentifObiectNume_SP_Result> GetObiectByNume(string nume);
        long Add(long idObiect, string nume, string categorie);
        void Update(long idObiect, string nume, string categorie);
        void Delete(long idObiect);
    }
}
