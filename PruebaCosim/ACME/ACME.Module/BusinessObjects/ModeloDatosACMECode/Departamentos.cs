using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultProperty("NombreDepartamento")]
    public partial class Departamentos
    {
        public Departamentos(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
