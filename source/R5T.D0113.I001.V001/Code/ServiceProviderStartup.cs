using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0114;


namespace R5T.D0113.I001.V001
{
    public class ServiceProviderStartup : IServiceProviderStartup
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            var parentDirectoryPathProviderAction = Instances.ServiceAction.AddParentDirectoryPathProviderAction();

            // Run.
            services
                .Run(parentDirectoryPathProviderAction)
                ;

            return Task.CompletedTask;
        }
    }
}
