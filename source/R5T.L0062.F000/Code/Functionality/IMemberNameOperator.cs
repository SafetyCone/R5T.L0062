using System;

using R5T.T0132;


namespace R5T.L0062.F000
{
    [FunctionalityMarker]
    public partial interface IMemberNameOperator : IFunctionalityMarker
    {
        /// <summary>
        /// The name returned by <see cref="System.Reflection.MemberInfo.Name"/> needs to be adjusted for use in identity strings. 
        /// </summary>
        public string Modify_MemberName(string name)
        {
            var output = name;

            // Namespace token separator '.' becomes '#'.
            // (This happens when members are explicitly implemented.)
            output = Instances.StringOperator.Replace_Character(
                output,
                Instances.TokenSeparators.NamespaceTokenSeparator,
                Instances.TokenSeparators.ExplicitImplementationNamespaceTokenSeparator);

            // Generic type input lists token separators '<' and '>' become '{' and '}'.
            output = Instances.StringOperator.Replace_Character(
                output,
                Instances.TokenSeparators.TypeArgumentListOpenTokenSeparator_Standard,
                Instances.TokenSeparators.TypeArgumentListOpenTokenSeparator);

            output = Instances.StringOperator.Replace_Character(
                output,
                Instances.TokenSeparators.TypeArgumentListCloseTokenSeparator_Standard,
                Instances.TokenSeparators.TypeArgumentListCloseTokenSeparator);

            // The type name separator in generic type input lists for explicitly implemented members changes from ',' to '@'.
            output = Instances.StringOperator.Replace_Character(
                output,
                Instances.TokenSeparators.ArgumentListSeparator,
                Instances.TokenSeparators.ExplicitImplementationArgumentListSeparator);

            return output;
        }
    }
}
