using System;

using R5T.Magyar.T002;

using R5T.T0042;


namespace R5T.D0113.X000
{
    public static class Instances
    {
        public static IExceptionGenerator ExceptionGenerator { get; } = Magyar.T002.ExceptionGenerator.Instance;
        public static IStringOperator StringOperator { get; } = T0042.StringOperator.Instance;
    }
}
