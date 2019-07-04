using System;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace VMSchedulerFunc
{
    public static class VMStarter
    {
        [FunctionName("VMStarter")]
        public static void Run([TimerTrigger("0 0 7 * * *")]TimerInfo myTimer, ILogger log)
        {
            var azure = AzureManager.Init();

            azure.VirtualMachines.Start("Gangasolutions", "ganga-vm");

            log.LogInformation($"VM Started at: {DateTime.Now}");

        }
    }
}
