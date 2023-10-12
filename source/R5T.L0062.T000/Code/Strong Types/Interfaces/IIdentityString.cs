using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0062.T000
{
    /// <summary>
    /// Strongly-types a string as a .NET member identity string.
    /// <para>See: <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/#id-strings"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IIdentityString : IStrongTypeMarker,
        ITyped<string>
    {
    }
}