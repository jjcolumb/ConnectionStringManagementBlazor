using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConnectionStringManagementBlazor.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("ConnectionName")]  
    public class ConnectionStrings : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ConnectionStrings(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
  

        string connectionName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ConnectionName
        {
            get => connectionName;
            set => SetPropertyValue(nameof(ConnectionName), ref connectionName, value);
        }

        string connectionString;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ConnectionString
        {
            get => connectionString;
            set => SetPropertyValue(nameof(ConnectionString), ref connectionString, value);
        }
    }
}
