using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultProperty("NombreOficina")]
    public partial class Oficinas
    {
        public Oficinas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
