using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultClassOptions, ImageName("BO_Report")]
    public partial class AplicacionServicios
    {
        public AplicacionServicios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
