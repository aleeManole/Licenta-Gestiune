using ServiceLayer.Attributes;
using System;
using System.Collections.Generic;



namespace ServiceLayer.Interfaces
{
    public interface ISubinventarService
    {
        IEnumerable<ListaSubinv_SP_Result> List();
        IEnumerable<IdentifSubinvObiect_Result> SubinventareByObj(long id);
        long Add(SubinventarAttributes subinventarAttributes);
        void Delete(long idSubinventar);
        void Update(SubinventarAttributes subinventarAttributes);
    }
}
