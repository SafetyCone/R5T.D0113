using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0113.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ParentDirectoryPathProvider"/> implementation of <see cref="IParentDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddParentDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IParentDirectoryPathProvider, ParentDirectoryPathProvider>();

            return services;
        }
    }
}