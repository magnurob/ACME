using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
namespace ACME.Module.BusinessObjects.bdACME
{
    [DefaultClassOptions, ImageName("BO_Employee")]
    [DefaultProperty("Id")]
    public partial class Usuarios
    {
        public Usuarios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
