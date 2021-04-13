using System;
using DevExpress.ExpressApp.Xpo;

namespace ConnectionStringManagementBlazor.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}
