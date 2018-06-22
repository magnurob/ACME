using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultProperty("NombreGerencia")]
    public partial class Gerencias
    {
        public Gerencias(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
