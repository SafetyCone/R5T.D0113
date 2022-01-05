using System;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0118;


namespace R5T.D0113.V001
{
    [ServiceTestFixtureMarker]
    public abstract class IParentDirectoryPathProviderTestFixture : ServiceTestFixtureBase<IParentDirectoryPathProvider>
    {
        protected IParentDirectoryPathProviderTestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        [TestMethod]
        public async Task WindowsFilePath01()
        {
            var expectedValue = Instances.ExpectedValue.ParentDirectoryForWindowsFile01();

            var actualValue = await this.Service.GetParentDirectoryPath(expectedValue.Input);

            Instances.Assertion.AreEqual(expectedValue, actualValue);
        }

        /// <summary>
        /// Tests that an exception is thrown on an empty path. 
        /// </summary>
        [TestMethod]
        public async Task ExceptionOnEmptyPath()
        {
            await Instances.Assertion.ThrowsExceptionAsync<InvalidOperationException>(() =>
                this.Service.GetParentDirectoryPath(
                    Instances.Path.EmptyPath()));
        }

        /// <summary>
        /// Tests that an exception is thrown on a null path. 
        /// </summary>
        [TestMethod]
        public async Task ExceptionOnNullPath()
        {
            await Instances.Assertion.ThrowsExceptionAsync<InvalidOperationException>(() =>
                this.Service.GetParentDirectoryPath(
                    Instances.Path.NullPath()));
        }
    }
}
