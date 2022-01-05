using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0113
{
    /// <summary>
    /// A stringly-typed path operator.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IParentDirectoryPathProvider : IServiceDefinition
    {
        /// <summary>
        /// Gets the path of the parent directory of the path.
        /// If the path is a directory path, gets the directory path of the directory's parent directory.
        /// If the path is a file path, gets the directory path of the directory containing the file.
        /// Note: implementations should not reference a file system as the path operator should work whether or not the path exists.
        /// </summary>
        /// <param name="path">A file path or directory path, that may or may not exist.</param>
        /// <returns>The directory path of the parent directory of either the file or directory, or root directory.</returns>
        Task<string> GetParentDirectoryPath(string path);
    }
}