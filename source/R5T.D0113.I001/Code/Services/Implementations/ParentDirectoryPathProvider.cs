using System;
using System.IO;
using System.Threading.Tasks;

using R5T.T0064;

using R5T.D0113.X000;


namespace R5T.D0113.I001
{
    [ServiceImplementationMarker]
    public class ParentDirectoryPathProvider : IParentDirectoryPathProvider, IServiceImplementation
    {
        public Task<string> GetParentDirectoryPath(string path)
        {
            throw new NotImplementedException();

            //return Task.FromResult(output);
        }
    }
}