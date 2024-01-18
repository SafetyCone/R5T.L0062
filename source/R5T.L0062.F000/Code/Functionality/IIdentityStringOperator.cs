using System;

using R5T.T0132;
using R5T.T0221;


namespace R5T.L0062.F000
{
    [FunctionalityMarker]
    public partial interface IIdentityStringOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Append does not insert a <see cref="Z000.ITokenSeparators.NamespaceTokenSeparator"/>.
        /// </summary>
        public string Append(string part1, string part2)
        {
            var output = $"{part1}{part2}";
            return output;
        }

        public string Append_ElementTypeRelationshipMarkers(
            string typeName,
            ElementTypeRelationships elementTypeRelationships)
        {
            var output = Instances.ElementTypeRelationshipOperator.Append_ElementTypeRelationshipMarkers(
                typeName,
                elementTypeRelationships,
                Instances.TypeNameAffixes.Array_Suffix,
                Instances.TypeNameAffixes.ByReference_Suffix_String,
                Instances.TypeNameAffixes.Pointer_Suffix_String);

            return output;
        }

        public string Append_NestedTypeTypeName(
            string parentTypeName,
            string nestedTypeName)
        {
            var output = this.Combine(
                parentTypeName,
                nestedTypeName,
                Instances.TokenSeparators.NestedTypeNameTokenSeparator_String);

            return output;
        }

        /// <summary>
        /// Combine inserts a <see cref="Z000.ITokenSeparators.NamespaceTokenSeparator"/>.
        /// </summary>
        public string Combine(string part1, string part2)
        {
            var output = this.Combine(
                part1,
                part2,
                Instances.TokenSeparators.NamespaceTokenSeparator_String);

            return output;
        }

        public string Combine(
            string part1,
            string part2,
            string separator)
        {
            var output = $"{part1}{separator}{part2}";
            return output;
        }

        public string Get_GenericParameterCountToken(
            int genericTypeParameterCount,
            string parameterCountTokenSeparator)
        {
            var output = $"{parameterCountTokenSeparator}{genericTypeParameterCount}";
            return output;
        }

        public string Get_GenericTypeParameterCountToken(int genericTypeParameterCount)
        {
            var output = this.Get_GenericParameterCountToken(
                genericTypeParameterCount,
                Instances.TokenSeparators._Standard.TypeParameterCountSeparator_String);

            return output;
        }

        public string Get_GenericMethodParameterCountToken(int genericMethodParameterCount)
        {
            var output = this.Get_GenericParameterCountToken(
                genericMethodParameterCount,
                Instances.TokenSeparators._Standard.MethodTypeParameterCountSeparator);

            return output;
        }

        public string Get_ErrorIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_ErrorKindMarked(identityStringValue);
            return output;
        }

        public string Get_EventIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_EventKindMarked(identityStringValue);
            return output;
        }

        public string Get_FieldIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_FieldKindMarked(identityStringValue);
            return output;
        }

        public string Get_MethodIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_MethodKindMarked(identityStringValue);
            return output;
        }

        public string Get_PropertyIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_PropertyKindMarked(identityStringValue);
            return output;
        }

        public string Get_TypeIdentityString(string identityStringValue)
        {
            var output = Instances.KindMarkerOperator.Make_TypeKindMarked(identityStringValue);
            return output;
        }

        /// <inheritdoc cref=" IMemberNameOperator.Modify_MemberName(string)"/>
        public string Modify_MemberName(string name)
        {
            var output = Instances.MemberNameOperator.Modify_MemberName(name);
            return output;
        }
    }
}
