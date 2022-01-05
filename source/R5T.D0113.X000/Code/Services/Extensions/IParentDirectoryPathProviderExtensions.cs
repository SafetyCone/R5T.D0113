using System;


// Specifically namespaced extensions.
namespace R5T.D0113.X000
{
    public static class IParentDirectoryPathProviderExtensions
    {
        public static void VerifyPathIsNotNullAndNotEmpty(this IParentDirectoryPathProvider _,
            string path)
        {
            var pathIsNullOrEmpty = Instances.StringOperator.IsNullOrEmpty(path);

            if (pathIsNullOrEmpty)
            {
                throw Instances.ExceptionGenerator.PathWasNullOrEmpty();
            }
        }
    }
}