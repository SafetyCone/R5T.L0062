using System;
using System.Text;

using R5T.L0053.Extensions;
using R5T.T0132;


namespace R5T.L0062.F001
{
    /// <summary>
    /// Type operator for identity strings.
    /// </summary>
    [FunctionalityMarker]
    public partial interface ITypeOperator : IFunctionalityMarker,
        L0053.ITypeOperator
    {
        private static L0053.ITypeOperator Base => L0053.TypeOperator.Instance;


        /// <summary>
        /// Returns the namespaced type name, with a slight difference regarding the handling of nested type names relative to <see cref="L0053.ITypeOperator.Get_NamespacedTypeName(Type)"/>.
        /// The standard nested type name token separator (used by <see cref="Type.FullName"/>) is '+' (plus),
        /// but identity strings use the same '.' (period) as used for the namespace token separator.
        /// </summary>
        public new string Get_NamespacedTypeName(Type type)
        {
            // Get the standard namespaced type name, the replace all '+' (pluses) with '.' (periods).
            var standardNamespacedTypeName = Base.Get_NamespacedTypeName(type);

            var output = Instances.StringOperator.Replace(
                standardNamespacedTypeName,
                Instances.TokenSeparators.NestedTypeNameTokenSeparator,
                Instances.TokenSeparators.NestedTypeNameTokenSeparator_Standard);

            return output;
        }

        /// <summary>
        /// For a type instance that specifies the type of a parameter,
        /// get the namespaced type name, inclusive of any generic type parameters.
        /// </summary>
        public string Get_NamespacedTypeName_ForParameterType(Type type)
        {
            // Does the type have an element type? (Arrays, by-reference, etc.)
            var hasElementType = type.HasElementType;
            if (hasElementType)
            {
                // If the type has an element type, get the element type name, then figure out the array suffix and add it.
                var elementType = type.GetElementType();

                var elementTypeNamespacedTypeName = this.Get_NamespacedTypeName_ForParameterType(elementType);

                var output = Instances.TypeNameOperator.Append_ElementTypeRelationshipMarker(
                    type,
                    elementTypeNamespacedTypeName,
                    Instances.TypeNameAffixes.Array_Suffix,
                    Instances.TypeNameAffixes.ByReference_Suffix,
                    Instances.TypeNameAffixes.Pointer_Suffix);

                return output;
            }

            // Is the type a generic parameter type?
            var isGenericParameterType = type.IsGenericParameter;
            if (isGenericParameterType)
            {
                var output = Instances.TypeNameOperator.Get_PositionalTypeName_ForGenericParameter(type);
                return output;
            }

            // At this point, we have an actual type.s
            var namespacedTypeName = this.Get_NamespacedTypeName(type);

            // Is the type a constructed generic type?
            var isConstructedGenericType = type.IsConstructedGenericType;
            if (isConstructedGenericType)
            {
                var builder = new StringBuilder();

                var beginningOfNamespacedTypeName = Instances.NamespacedTypeNameOperator.Get_Substring_Upto_GenericTypeParameterCount(namespacedTypeName);
                var endingOfNamespacedTypeName = Instances.NamespacedTypeNameOperator.Get_Substring_After_GenericTypeParameterCount(namespacedTypeName);

                builder.Append(beginningOfNamespacedTypeName);

                var typeInputs = this.Get_GenericTypeInputs_OfType(type);

                builder.Append(Instances.TokenSeparators.TypeArgumentListOpenTokenSeparator);

                foreach (var typeArgument in typeInputs)
                {
                    var typeName = this.Get_NamespacedTypeName_ForParameterType(typeArgument);

                    builder.Append(typeName);
                    builder.Append(Instances.TokenSeparators.ArgumentListSeparator);
                }

                builder.Remove_Last();

                builder.Append(Instances.TokenSeparators.TypeArgumentListCloseTokenSeparator);

                builder.Append(endingOfNamespacedTypeName);

                var output = builder.ToString();
                return output;
            }

            // Else, just return the namespaced type name.
            return namespacedTypeName;
        }

        public string Handle_ConversionOperatorGenericTypeName(
            Type type,
            string parameterNamespacedTypeName)
        {
            var positionBasedTypeName = Instances.TypeNameAffixes.GenericTypeParameterType_Prefix + type.GenericParameterPosition;
            var genericTypeName = type.Name;

            var output = parameterNamespacedTypeName.Replace(positionBasedTypeName, genericTypeName);
            return output;
        }
    }
}
