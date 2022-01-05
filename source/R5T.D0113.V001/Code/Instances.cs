using System;

using R5T.T0021;
using R5T.T0119;


namespace R5T.D0113.V001
{
    public static class Instances
    {
        public static IAssertion Assertion { get; } = T0119.Assertion.Instance;
        public static IExpectedValue ExpectedValue { get; } = T0119.ExpectedValue.Instance;
        public static IPath Path { get; } = T0021.Path.Instance;
    }
}
