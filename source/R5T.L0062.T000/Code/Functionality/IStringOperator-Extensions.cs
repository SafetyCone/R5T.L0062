using System;

using R5T.T0132;


namespace R5T.L0062.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IIdentityString"/>
        public IIdentityString ToIdentityString(string value)
        {
            var output = new IdentityString(value);
            return output;
        }
    }
}
