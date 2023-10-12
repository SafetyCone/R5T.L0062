using System;

using R5T.T0132;


namespace R5T.L0062.F001
{
    [FunctionalityMarker]
    public partial interface IExceptionOperator : IFunctionalityMarker,
        L0053.IExceptionOperator
    {
        public Exception Get_UnknownGenericParameterTypeRelationshipException()
        {
            var output = new Exception("Unknown generic parameter type relationship.");
            return output;
        }
    }
}
