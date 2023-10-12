using System;


namespace R5T.L0062.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToIdentityString(string)"/>
        public static IIdentityString ToIdentityString(this string value)
        {
            return Instances.StringOperator_Extensions.ToIdentityString(value);
        }
    }
}
