using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.D0113.V001;
using R5T.D0114;


namespace R5T.D0113.I001.V001
{
    [TestClass]
    public class ParentDirectoryPathProviderTests : IParentDirectoryPathProviderTestFixture
    {
        #region Static

        private static ServiceProvider ServiceProvider { get; set; }


        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            ParentDirectoryPathProviderTests.ServiceProvider = Instances.ServiceProvider.NewBuilder()
                .UseServiceProviderStartup<ServiceProviderStartup, T0079.IServiceProviderBuilder>(
                    Instances.ServiceAction.AddServiceProviderStartupAction())
                .Build()
                ;
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ParentDirectoryPathProviderTests.ServiceProvider.Dispose();
        }

        #endregion


        public ParentDirectoryPathProviderTests()
            : base(ParentDirectoryPathProviderTests.ServiceProvider)
        {
        }
    }
}