using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IGestionarService
    {
        IEnumerable<ListaGestionariFacultate_SP_Result> List();
        Gestionar GetGestionarFacultate(short idFacultate);
    }
}
