using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0062.T000
{
    /// <inheritdoc cref="IIdentityString"/>
    [StrongTypeImplementationMarker]
    public class IdentityString : TypedBase<string>, IStrongTypeMarker,
        IIdentityString
    {
        public IdentityString(string value)
            : base(value)
        {
        }
    }
}