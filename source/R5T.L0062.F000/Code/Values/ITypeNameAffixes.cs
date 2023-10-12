using System;

using R5T.T0131;


namespace R5T.L0062.F000
{
    [ValuesMarker]
    public partial interface ITypeNameAffixes : IValuesMarker,
        Z000.ITypeNameAffixes
    {
        private static L0053.ITypeNameAffixes Standard => L0053.TypeNameAffixes.Instance;


        /// <summary>
        /// <para><inheritdoc cref="L0066.ITypeNameAffixes.ByReference_Suffix" path="/summary/descendant::name"/></para>
        /// The standard by-reference type name suffix (used by <see cref="Type.FullName"/>) is '&amp;' (ampersand).
        /// But for identity strings, by-reference type name suffix is '@' (alphasand).
        /// </summary>
        public char ByReference_Suffix_Standard => Standard.ByReference_Suffix;
    }
}
