using System;

using R5T.T0131;


namespace R5T.L0062.Z000
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker,
        L001.ITokenSeparators
    {
        /// <summary>
        /// <para>',' (comma)</para>
        /// </summary>
        public const char ArgumentListSeparator_Constant = ',';

        /// <inheritdoc cref="ArgumentListSeparator_Constant"/>
        public char ArgumentListSeparator => ArgumentListSeparator_Constant;

        /// <summary>
        /// <para>'#' (hash)</para>
        /// In the type input lists of explicitly implemented members, the namespaced token separator changes from '.' to '#'.
        /// </summary>
        public const char ExplicitImplementationNamespaceTokenSeparator_Constant = '#';

        /// <inheritdoc cref="ExplicitImplementationNamespaceTokenSeparator_Constant"/>
        public char ExplicitImplementationNamespaceTokenSeparator => ExplicitImplementationNamespaceTokenSeparator_Constant;

        /// <summary>
        /// <para>'@' (alphasand)</para>
        /// In the type input lists of explicitly implemented members, the type name separator changes from ',' to '@'.
        /// </summary>
        public const char ExplicitImplementationArgumentListSeparator_Constant = '@';

        /// <inheritdoc cref="ExplicitImplementationArgumentListSeparator_Constant"/>
        public char ExplicitImplementationArgumentListSeparator => ExplicitImplementationArgumentListSeparator_Constant;

        /// <summary>
        /// <para>'@' (at-sign, alphasand)</para>
        /// </summary>
        public const char MemberNameArgumentListSeparator_Constant = '@';

        /// <inheritdoc cref="MemberNameArgumentListSeparator_Constant"/>
        public char MemberNameArgumentListSeparator => MemberNameArgumentListSeparator_Constant;

        /// <summary>
        /// <para>',' (comma)</para>
        /// Separates items in a list.
        /// </summary>
        public const char ListItemsTokenSeparator_Constant = ',';

        /// <inheritdoc cref="ListItemsTokenSeparator_Constant"/>
        public char ListItemsTokenSeparator => ListItemsTokenSeparator_Constant;

        /// <summary>
        /// <para>'{' (open-brace)</para>
        /// </summary>
        public const char TypeArgumentListOpenTokenSeparator_Constant = '{';

        /// <inheritdoc cref="TypeArgumentListOpenTokenSeparator_Constant"/>
        public char TypeArgumentListOpenTokenSeparator => TypeArgumentListOpenTokenSeparator_Constant;

        /// <summary>
        /// <para>'}' (close-brace)</para>
        /// </summary>
        public const char TypeArgumentListCloseTokenSeparator_Constant = '}';

        /// <inheritdoc cref="TypeArgumentListCloseTokenSeparator_Constant"/>
        public char TypeArgumentListCloseTokenSeparator => TypeArgumentListCloseTokenSeparator_Constant;

        /// <summary>
        /// <para>'`' (back-tick)</para>
        /// Separates the namespaced type name for type names (or namespaced typed method name for method names)
        /// from the type parameter count and then the rest of the identity name value.
        /// </summary>
        public const char TypeParameterCountTokenSeparator_Constant = '`';

        /// <inheritdoc cref="TypeParameterCountTokenSeparator_Constant"/>
        public char TypeParameterCountTokenSeparator => TypeParameterCountTokenSeparator_Constant;

        /// <summary>
        /// <para>'`1' (two back-ticks)</para>
        /// </summary>
        public const string MethodTypeParameterCountTokenSeparator_Constant = "``";

        /// <inheritdoc cref="MethodTypeParameterCountTokenSeparator_Constant"/>
        public string MethodTypeParameterCountTokenSeparator => MethodTypeParameterCountTokenSeparator_Constant;

        /// <summary>
        /// <para>'.' (period)</para>
        /// Separates tokens in a namespaced name (namespace name, namespaced type name) from each other.
        /// </summary>
        public const char NamespaceTokenSeparator_Constant = '.';

        /// <inheritdoc cref="NamespaceTokenSeparator_Constant"/>
        public char NamespaceTokenSeparator => NamespaceTokenSeparator_Constant;

        /// <inheritdoc cref="NamespaceTokenSeparator_Constant"/>
        public const string NamespaceTokenSeparator_String_Constant = ".";

        /// <inheritdoc cref="NamespaceTokenSeparator_String_Constant"/>
        public string NamespaceTokenSeparator_String => NamespaceTokenSeparator_String_Constant;

        /// <summary>
        /// <para>'.' (period)</para>
        /// Separates tokens in a nested type name (parent type name, child type name) from each other.
        /// The nested type name token separator is the same as the namespaced token separator.
        /// <para>Note: this is different from the standard nested type name token separator (used by <see cref="Type.FullName"/>), which is '+' (plus).</para>
        /// </summary>
        public const char NestedTypeNameTokenSeparator_Constant = '.';

        /// <inheritdoc cref="NestedTypeNameTokenSeparator_Constant"/>
        public char NestedTypeNameTokenSeparator => NestedTypeNameTokenSeparator_Constant;

        /// <inheritdoc cref="NestedTypeNameTokenSeparator_Constant"/>
        public const string NestedTypeNameTokenSeparator_String_Constant = ".";

        /// <inheritdoc cref="NestedTypeNameTokenSeparator_String_Constant"/>
        public string NestedTypeNameTokenSeparator_String => NestedTypeNameTokenSeparator_String_Constant;

        /// <summary>
        /// <para>'~' (tilde)</para>
        /// Separates the namespaced, typed, argumented, method name from its output type.
        /// Used for implicit and explicit operator methods.
        /// </summary>
        public const char OutputTypeTokenSeparator_Constant = '~';

        /// <inheritdoc cref="OutputTypeTokenSeparator_Constant"/>
        public char OutputTypeTokenSeparator => OutputTypeTokenSeparator_Constant;

        /// <summary>
        /// <para>'(' (open-parenthesis)</para>
        /// Separates the namespaced, typed, method name from its parameter list.
        /// </summary>
        public const char ParameterListOpenTokenSeparator_Constant = '(';

        /// <inheritdoc cref="ParameterListOpenTokenSeparator_Constant"/>
        public char ParameterListOpenTokenSeparator => ParameterListOpenTokenSeparator_Constant;

        /// <summary>
        /// <para>')' (close-parenthesis)</para>
        /// Closes the parameter list for a method identity string.
        /// </summary>
        public const char ParameterListCloseTokenSeparator_Constant = ')';

        /// <inheritdoc cref="ParameterListCloseTokenSeparator_Constant"/>
        public char ParameterListCloseTokenSeparator => ParameterListCloseTokenSeparator_Constant;
    }
}
