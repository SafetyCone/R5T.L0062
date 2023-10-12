using System;

using R5T.T0132;


namespace R5T.L0062.L001
{
    [FunctionalityMarker]
    public partial interface IExceptionOperator : IFunctionalityMarker
    {
        public Exception Get_UnrecognizedKindMarkerException(char kindMarker)
        {
            return new Exception($"{kindMarker}: Unrecognized kind marker.");
        }
    }
}
