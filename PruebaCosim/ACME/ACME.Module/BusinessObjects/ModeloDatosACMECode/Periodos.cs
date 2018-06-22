using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultProperty("Periodo")]
    public partial class Periodos
    {
        public Periodos(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
