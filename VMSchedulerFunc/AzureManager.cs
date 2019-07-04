using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMSchedulerFunc
{
    public class AzureManager
    {
        public static IAzure Init()
        {
            var credentials =
                SdkContext.AzureCredentialsFactory
                    .FromServicePrincipal("2f817703-60e0-40f7-af9a-739b97e3ff3a"
                        , "3X?Ej-Ql.L0OWhRii6Fl]1U[v_m*[C@j"
                        , "8c4e6042-1491-4645-9d25-8c2628f7bff3"
                        , AzureEnvironment.AzureGlobalCloud);

            var azure = Azure.Configure().WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(credentials).WithDefaultSubscription();

            return azure;
        }
    }
}
