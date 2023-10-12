using System;

using R5T.T0131;


namespace R5T.L0062.F000
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker,
        Z000.ITokenSeparators
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0053.ITokenSeparators _Standard => L0053.TokenSeparators.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><inheritdoc cref="L0053.ITokenSeparators.NestedTypeNameTokenSeparator" path="/summary/descendant::name"/></para>
        /// The standard nested type name token separator (used by <see cref="Type.FullName"/>) is '+' (plus).
        /// But for identity strings, the nested type name token separator is '.' (period), which is the same as the namespace token separator.
        /// </summary>
        public char NestedTypeNameTokenSeparator_Standard => _Standard.NestedTypeNameTokenSeparator;

        /// <summary>
        /// <para><inheritdoc cref="L0053.ITokenSeparators.TypeArgumentListOpenTokenSeparator" path="/summary/descendant::name"/></para>
        /// The standard type argument list open token separator (used by <see cref="Type.FullName"/>) is '&lt;' (open-angle bracket).
        /// But for identity strings, the type argument list open token separator is '{' (open brace).
        /// </summary>
        public char TypeArgumentListOpenTokenSeparator_Standard => _Standard.TypeArgumentListOpenTokenSeparator;

        /// <summary>
        /// <para><inheritdoc cref="L0053.ITokenSeparators.TypeArgumentListCloseTokenSeparator" path="/summary/descendant::name"/></para>
        /// The standard type argument list close token separator (used by <see cref="Type.FullName"/>) is '&gt;' (close-angle bracket).
        /// But for identity strings, the type argument list close token separator is '}' (close brace).
        /// </summary>
        public char TypeArgumentListCloseTokenSeparator_Standard => _Standard.TypeArgumentListCloseTokenSeparator;
    }
}
