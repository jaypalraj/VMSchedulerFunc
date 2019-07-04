using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace VMSchedulerFunc
{
    public static class VMStopper
    {
        [FunctionName("VMStopper")]
        public static void Run([TimerTrigger("0 0 19 * * *")]TimerInfo myTimer, ILogger log)
        {
            var azure = AzureManager.Init();

            azure.VirtualMachines.Deallocate("Gangasolutions", "ganga-vm");

            log.LogInformation($"VM Stopped at: {DateTime.Now}");
        }
    }
}
