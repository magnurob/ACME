using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultProperty("NombreServicios")]
    public partial class Servicios
    {
        public Servicios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
