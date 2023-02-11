﻿using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0113.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ParentDirectoryPathProvider"/> implementation of <see cref="IParentDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IParentDirectoryPathProvider> AddParentDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IParentDirectoryPathProvider>(services => services.AddParentDirectoryPathProvider());
            return serviceAction;
        }
    }
}
