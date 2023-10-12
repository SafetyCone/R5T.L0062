using System;

using R5T.T0131;


namespace R5T.L0062.Z000
{
    [ValuesMarker]
    public partial interface ITypeNameAffixes : IValuesMarker
    {
        /// <summary>
        /// <para><name>"[]" (open- and close-bracket pair)</name></para>
        /// </summary>
        public string Array_Suffix => "[]";

        /// <summary>
        /// <para><name>'@' (at-sign, a.k.a. alphasands)</name></para>
        /// Indicates that a type is passed by reference.
        /// </summary>
        public const char ByReference_Suffx_Constant = '@';

        /// <inheritdoc cref="ByReference_Suffx_Constant"/>
        public char ByReference_Suffix => ByReference_Suffx_Constant;

        /// <inheritdoc cref="ByReference_Suffx_Constant"/>
        public const string ByReference_Suffx_String_Constant = "@";

        /// <inheritdoc cref="ByReference_Suffx_String_Constant"/>
        public string ByReference_Suffix_String => ByReference_Suffx_String_Constant;

        /// <summary>
        /// <para><name>"`" (tick)</name></para>
        /// </summary>
        public string GenericTypeParameterType_Prefix => "`";

        /// <summary>
        /// <para><name>"``" (double-tick)</name></para>
        /// </summary>
        public string GenericMethodParameterType_Prefix => "``";

        /// <summary>
        /// <para><name>"*" (the asterix)</name></para>
        /// </summary>
        public char Pointer_Suffix => '*';

        /// <inheritdoc cref="Pointer_Suffix"/>
        public string Pointer_Suffix_String => "*";
    }
}
