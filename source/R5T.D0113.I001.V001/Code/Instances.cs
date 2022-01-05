using System;

using R5T.T0021;
using R5T.T0062;


namespace R5T.D0113.I001.V001
{
    public static class Instances
    {
        public static IPath Path { get; } = T0021.Path.Instance;
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static T0061.IServiceProvider ServiceProvider { get; } = T0061.ServiceProvider.Instance;
    }
}
