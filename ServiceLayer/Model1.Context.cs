﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class gestiuneInventar2Entities : DbContext
    {
        public gestiuneInventar2Entities()
            : base("name=gestiuneInventar2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Angajat> Angajats { get; set; }
        public virtual DbSet<Depozit> Depozits { get; set; }
        public virtual DbSet<Facultate> Facultates { get; set; }
        public virtual DbSet<Gestionar> Gestionars { get; set; }
        public virtual DbSet<Obiect> Obiects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subinventar> Subinventars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransferIntrare> TransferIntrares { get; set; }
        public virtual DbSet<TransferuriIesire> TransferuriIesires { get; set; }
    
        public virtual int AdaugareObiect_SP(Nullable<long> idObiect, string nume, string categorie)
        {
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var categorieParameter = categorie != null ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdaugareObiect_SP", idObiectParameter, numeParameter, categorieParameter);
        }
    
        public virtual ObjectResult<DepoziteFacultate_SP_Result> DepoziteFacultate_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DepoziteFacultate_SP_Result>("DepoziteFacultate_SP");
        }
    
        public virtual ObjectResult<IdentifAngajFacult_Result> IdentifAngajFacult(Nullable<int> idFacultate)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifAngajFacult_Result>("IdentifAngajFacult", idFacultateParameter);
        }
    
        public virtual int IdentifGestFacult_SP(Nullable<short> idFacultate)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IdentifGestFacult_SP", idFacultateParameter);
        }
    
        public virtual ObjectResult<IdentifObiectNume_SP_Result> IdentifObiectNume_SP(string nume)
        {
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifObiectNume_SP_Result>("IdentifObiectNume_SP", numeParameter);
        }
    
        public virtual ObjectResult<IdentifStudentFacult_SP_Result> IdentifStudentFacult_SP(Nullable<int> idFacultate)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifStudentFacult_SP_Result>("IdentifStudentFacult_SP", idFacultateParameter);
        }
    
        public virtual ObjectResult<IdentifSubinvObiect_Result> IdentifSubinvObiect(Nullable<long> idObiect)
        {
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifSubinvObiect_Result>("IdentifSubinvObiect", idObiectParameter);
        }
    
        public virtual ObjectResult<ListaDepCasare_Sp_Result> ListaDepCasare_Sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaDepCasare_Sp_Result>("ListaDepCasare_Sp");
        }
    
        public virtual ObjectResult<ListaDepozite_SP_Result> ListaDepozite_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaDepozite_SP_Result>("ListaDepozite_SP");
        }
    
        public virtual ObjectResult<ListaFacultati_SP_Result> ListaFacultati_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaFacultati_SP_Result>("ListaFacultati_SP");
        }
    
        public virtual ObjectResult<ListaObiecte_SP_Result> ListaObiecte_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaObiecte_SP_Result>("ListaObiecte_SP");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Gestionar> GestionarPeFacultate(Nullable<short> idFacultate)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Gestionar>("GestionarPeFacultate", idFacultateParameter);
        }
    
        public virtual ObjectResult<Gestionar> GestionarPeFacultate(Nullable<short> idFacultate, MergeOption mergeOption)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Gestionar>("GestionarPeFacultate", mergeOption, idFacultateParameter);
        }
    
        public virtual ObjectResult<IdentifStudentCnp_SP_Result> IdentifStudentCnp_SP(string cnp)
        {
            var cnpParameter = cnp != null ?
                new ObjectParameter("cnp", cnp) :
                new ObjectParameter("cnp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifStudentCnp_SP_Result>("IdentifStudentCnp_SP", cnpParameter);
        }
    
        public virtual ObjectResult<ListaGestionariFacultate_SP_Result> ListaGestionariFacultate_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaGestionariFacultate_SP_Result>("ListaGestionariFacultate_SP");
        }
    
        public virtual ObjectResult<IdentifGestPerFacult_SP_Result> IdentifGestPerFacult_SP(Nullable<short> idFacultate)
        {
            var idFacultateParameter = idFacultate.HasValue ?
                new ObjectParameter("idFacultate", idFacultate) :
                new ObjectParameter("idFacultate", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IdentifGestPerFacult_SP_Result>("IdentifGestPerFacult_SP", idFacultateParameter);
        }
    
        public virtual ObjectResult<ListaGestByFacul_SP_Result> ListaGestByFacul_SP(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaGestByFacul_SP_Result>("ListaGestByFacul_SP", idParameter);
        }
    
        public virtual ObjectResult<ListaObjByCateg_SP_Result> ListaObjByCateg_SP(string categorie)
        {
            var categorieParameter = categorie != null ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaObjByCateg_SP_Result>("ListaObjByCateg_SP", categorieParameter);
        }
    
        public virtual int DeleteObj_SP(Nullable<long> idObiect)
        {
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteObj_SP", idObiectParameter);
        }
    
        public virtual int DeleteSubinv_SP(Nullable<long> idSubinventar)
        {
            var idSubinventarParameter = idSubinventar.HasValue ?
                new ObjectParameter("idSubinventar", idSubinventar) :
                new ObjectParameter("idSubinventar", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSubinv_SP", idSubinventarParameter);
        }
    
        public virtual int InsertObj_SP(Nullable<long> idObiect, string nume, string categorie)
        {
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var categorieParameter = categorie != null ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertObj_SP", idObiectParameter, numeParameter, categorieParameter);
        }
    
        public virtual int InsertSubinv_SP(Nullable<long> idSubinventar, Nullable<long> idStudent, Nullable<int> idAngajat, Nullable<int> idDepozit, Nullable<System.DateTime> dataPrimire, Nullable<System.DateTime> dataPredare, Nullable<long> idObiect, Nullable<int> cantitate)
        {
            var idSubinventarParameter = idSubinventar.HasValue ?
                new ObjectParameter("idSubinventar", idSubinventar) :
                new ObjectParameter("idSubinventar", typeof(long));
    
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("idStudent", idStudent) :
                new ObjectParameter("idStudent", typeof(long));
    
            var idAngajatParameter = idAngajat.HasValue ?
                new ObjectParameter("idAngajat", idAngajat) :
                new ObjectParameter("idAngajat", typeof(int));
    
            var idDepozitParameter = idDepozit.HasValue ?
                new ObjectParameter("idDepozit", idDepozit) :
                new ObjectParameter("idDepozit", typeof(int));
    
            var dataPrimireParameter = dataPrimire.HasValue ?
                new ObjectParameter("dataPrimire", dataPrimire) :
                new ObjectParameter("dataPrimire", typeof(System.DateTime));
    
            var dataPredareParameter = dataPredare.HasValue ?
                new ObjectParameter("dataPredare", dataPredare) :
                new ObjectParameter("dataPredare", typeof(System.DateTime));
    
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            var cantitateParameter = cantitate.HasValue ?
                new ObjectParameter("cantitate", cantitate) :
                new ObjectParameter("cantitate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSubinv_SP", idSubinventarParameter, idStudentParameter, idAngajatParameter, idDepozitParameter, dataPrimireParameter, dataPredareParameter, idObiectParameter, cantitateParameter);
        }
    
        public virtual int UpdateObj_SP(Nullable<long> idObiect, string nume, string categorie)
        {
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var categorieParameter = categorie != null ?
                new ObjectParameter("categorie", categorie) :
                new ObjectParameter("categorie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateObj_SP", idObiectParameter, numeParameter, categorieParameter);
        }
    
        public virtual int UpdateSubinv_SP(Nullable<long> idSubinventar, Nullable<long> idStudent, Nullable<int> idAngajat, Nullable<int> idDepozit, Nullable<System.DateTime> dataPrimire, Nullable<System.DateTime> dataPredare, Nullable<long> idObiect, Nullable<int> cantitate)
        {
            var idSubinventarParameter = idSubinventar.HasValue ?
                new ObjectParameter("idSubinventar", idSubinventar) :
                new ObjectParameter("idSubinventar", typeof(long));
    
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("idStudent", idStudent) :
                new ObjectParameter("idStudent", typeof(long));
    
            var idAngajatParameter = idAngajat.HasValue ?
                new ObjectParameter("idAngajat", idAngajat) :
                new ObjectParameter("idAngajat", typeof(int));
    
            var idDepozitParameter = idDepozit.HasValue ?
                new ObjectParameter("idDepozit", idDepozit) :
                new ObjectParameter("idDepozit", typeof(int));
    
            var dataPrimireParameter = dataPrimire.HasValue ?
                new ObjectParameter("dataPrimire", dataPrimire) :
                new ObjectParameter("dataPrimire", typeof(System.DateTime));
    
            var dataPredareParameter = dataPredare.HasValue ?
                new ObjectParameter("dataPredare", dataPredare) :
                new ObjectParameter("dataPredare", typeof(System.DateTime));
    
            var idObiectParameter = idObiect.HasValue ?
                new ObjectParameter("idObiect", idObiect) :
                new ObjectParameter("idObiect", typeof(long));
    
            var cantitateParameter = cantitate.HasValue ?
                new ObjectParameter("cantitate", cantitate) :
                new ObjectParameter("cantitate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSubinv_SP", idSubinventarParameter, idStudentParameter, idAngajatParameter, idDepozitParameter, dataPrimireParameter, dataPredareParameter, idObiectParameter, cantitateParameter);
        }
    
        public virtual ObjectResult<ListaSubinv_SP_Result> ListaSubinv_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaSubinv_SP_Result>("ListaSubinv_SP");
        }
    }
}