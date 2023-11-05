using System;
using System.Linq;
using System.Reflection;

using R5T.T0132;


namespace R5T.L0062.F001.Platform
{
    [FunctionalityMarker]
    public partial interface IMemberInfoOperator : IFunctionalityMarker,
        L0053.IMemberInfoOperator
    {
        private static L0053.IMemberInfoOperator Base => L0053.MemberInfoOperator.Instance;


        public string Get_IdentityString(MemberInfo memberInfo)
        {
            var output = memberInfo switch
            {
                ConstructorInfo constructorInfo => this.Get_IdentityString_ForConstructor(constructorInfo),
                EventInfo eventInfo => this.Get_IdentityString_ForEvent(eventInfo),
                FieldInfo fieldInfo => this.Get_IdentityString_ForField(fieldInfo),
                MethodInfo methodInfo => this.Get_IdentityString_ForMethod(methodInfo),
                PropertyInfo propertyInfo => this.Get_IdentityString_ForProperty(propertyInfo),
                TypeInfo typeInfo => this.Get_IdentityString_ForType(typeInfo),
                _ => throw Instances.ExceptionOperator.Get_UnrecognizedMemberTypeException(memberInfo),
            };

            return output;
        }

        public string Get_IdentityString_ForConstructor(ConstructorInfo constructorInfo)
        {
            var namespacedTypedName = this.Get_NamespacedTypedName(constructorInfo);

            var parameters = constructorInfo.GetParameters();

            var parametersPart = this.Get_ParametersPart(parameters);

            var namespacedTypedParameterTypedName = Instances.IdentityStringOperator._Platform.Append(
                namespacedTypedName,
                parametersPart);

            var output = Instances.IdentityStringOperator._Platform.Get_MethodIdentityString(namespacedTypedParameterTypedName);
            return output;
        }

        public string Get_IdentityString_ForEvent(EventInfo eventInfo)
        {
            var namespacedTypedName = this.Get_NamespacedTypedName(eventInfo);

            var output = Instances.IdentityStringOperator._Platform.Get_EventIdentityString(namespacedTypedName);
            return output;
        }

        public string Get_IdentityString_ForField(FieldInfo fieldInfo)
        {
            var namespacedTypedName = this.Get_NamespacedTypedName(fieldInfo);

            var output = Instances.IdentityStringOperator._Platform.Get_FieldIdentityString(namespacedTypedName);
            return output;
        }

        public string Get_IdentityString_ForMethod(MethodInfo methodInfo)
        {
            var namespacedTypedName = this.Get_NamespacedTypedName(methodInfo);

            var methodName = namespacedTypedName;

            var isGeneric = Instances.MethodInfoOperator.Is_Generic(methodInfo);
            if (isGeneric)
            {
                methodName = Instances.IdentityStringOperator._Platform.Append_MethodTypeParametersCount(
                    methodName,
                    methodInfo);
            }

            // Need to account for parameter types.
            try
            {
                // This fails on pointer types.
                var parametersPart = this.Get_ParametersPart(methodInfo);

                methodName = Instances.IdentityStringOperator._Platform.Append(
                    methodName,
                    parametersPart);
            }
            // Function pointers are not supported.
            catch (NotSupportedException)
            {
                // Do nothing.
            }

            // Handle implicit and explicit conversion operators.
            var isConversionOperator = Instances.MethodInfoOperator.Is_ConversionOperator(methodInfo);
            if (isConversionOperator)
            {
                // Append the return type.
                var returnType = methodInfo.ReturnType;

                // Use the parameter type code for the return type.
                var returnTypeName = Instances.TypeOperator.Get_NamespacedTypeName_ForParameterType(returnType);

                // Weirdness for conversion operators and generic type parameters.
                if (returnType.IsGenericTypeParameter)
                {
                    returnTypeName = Instances.TypeOperator.Handle_ConversionOperatorGenericTypeName(
                        returnType,
                        returnTypeName);
                }

                if(returnType.HasElementType && returnType.GetElementType().IsGenericTypeParameter)
                {
                    returnTypeName = Instances.TypeOperator.Handle_ConversionOperatorGenericTypeName(
                        returnType.GetElementType(),
                        returnTypeName);
                }

                methodName += Instances.TokenSeparators.OutputTypeTokenSeparator + returnTypeName;
            }

            var output = Instances.IdentityStringOperator._Platform.Get_MethodIdentityString(methodName);
            return output;
        }

        public string Get_IdentityString_ForProperty(PropertyInfo propertyInfo)
        {
            var namespacedTypedName = this.Get_NamespacedTypedName(propertyInfo);

            var propertyName = namespacedTypedName;

            var isIndexer = Instances.PropertyInfoOperator.Is_Indexer(propertyInfo);
            if (isIndexer)
            {
                var parameterInfos = Instances.PropertyInfoOperator.Get_IndexerParameters(propertyInfo);

                var parametersPart = this.Get_ParametersPart(parameterInfos);

                propertyName = Instances.IdentityStringOperator._Platform.Append(
                    propertyName,
                    parametersPart);
            }

            var output = Instances.IdentityStringOperator._Platform.Get_PropertyIdentityString(propertyName);
            return output;
        }

        public string Get_IdentityString_ForType(TypeInfo typeInfo)
        {
            var namespacedTypeName = Instances.TypeOperator.Get_NamespacedTypeName(typeInfo);

            var output = Instances.IdentityStringOperator._Platform.Get_TypeIdentityString(namespacedTypeName);
            return output;
        }

        /// <summary>
        /// Gets the name of a member, adjusted by <see cref="Adjust_MemberName(string)"/>.
        /// <para><inheritdoc cref="Adjust_MemberName(string)" path="/summary"/></para>
        /// </summary>
        public new string Get_Name(MemberInfo memberInfo)
        {
            // Get the name of the member.
            var memberName = Base.Get_Name(memberInfo);

            // Now adjust the name for the identity string rules.
            var output = this.Adjust_MemberName(memberName);
            return output;
        }

        /// <summary>
        /// Adjusts the name of a member for:
        /// 1) Whether the member is explicitly implemented,
        /// 2) Whether the member name contains generic type arguments (for example, when explicitly implementing a generic interface),
        /// 3) Whether the member name contains multiple generic type arguments (for example, when explicitly implementing a generic interface)
        /// .
        /// </summary>
        public string Adjust_MemberName(string memberName)
        {
            var output = memberName;

            //// Tuple-craziness!
            //// In: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.21\ref\net6.0\System.Collections.dll
            //// Desired: M:System.Collections.Generic.PriorityQueue`2.UnorderedItemsCollection.System#Collections#Generic#IEnumerable{System#ValueTuple{TElement@TPriority}}#GetEnumerator
            //// Result: M:System.Collections.Generic.PriorityQueue`2.UnorderedItemsCollection.System#Collections#Generic#IEnumerable{(TElementElement@TPriorityPriority)}#GetEnumerator
            //var containsTuple = output.Contains('(');
            //if(containsTuple)
            //{
            //    var declaringType = memberInfo.DeclaringType;

            //    var declaringTypeInterfaceTypes = declaringType.GetInterfaces();
            //    foreach (var interfaceType in declaringTypeInterfaceTypes)
            //    {
            //        // Fails with exception: System.NotSupportedException: 'InterfaceMapping is not supported on assemblies loaded by a MetadataLoadContext.'
            //        var interfaceMap = declaringType.GetInterfaceMap(interfaceType);

            //        var interfaceContainsMember = interfaceMap.TargetMethods.Contains(memberInfo);
            //        if(interfaceContainsMember)
            //        {
            //            var containingInterfaceType = interfaceMap.InterfaceType;

            //            output = containingInterfaceType.Name;

            //            break;
            //        }
            //    }
            //}

            // Convert all namespace token separators ('.', periods) to hashes ('#').
            output = Instances.StringOperator.Replace(
                output,
                newCharacter: Instances.TokenSeparators.ExplicitImplementationNamespaceTokenSeparator,
                Instances.TokenSeparators.NamespaceTokenSeparator);

            // Convert all generic type list open and close token separators ('<' and '>', angle-braces) to braces ('{' and '}' respectively).
            output = Instances.StringOperator.Replace(
                output,
                newCharacter: Instances.TokenSeparators.TypeArgumentListOpenTokenSeparator,
                Instances.TokenSeparators.TypeArgumentListOpenTokenSeparator_Standard);

            output = Instances.StringOperator.Replace(
                output,
                newCharacter: Instances.TokenSeparators.TypeArgumentListCloseTokenSeparator,
                Instances.TokenSeparators.TypeArgumentListCloseTokenSeparator_Standard);

            // Convert all generic type list element separators (',', comma) to at-signs ('@', at-sign, alphasand).
            output = Instances.StringOperator.Replace(
                output,
                newCharacter: Instances.TokenSeparators.MemberNameArgumentListSeparator,
                Instances.TokenSeparators.ArgumentListSeparator);

            return output;
        }

        public string Get_NamespacedTypedName(MemberInfo memberInfo)
        {
            var namespacedTypeName = Instances.TypeOperator.Get_NamespacedTypeName(memberInfo.DeclaringType);
            var memberName = this.Get_Name(memberInfo);

            var output = Instances.IdentityStringOperator._Platform.Combine(namespacedTypeName, memberName);
            return output;
        }

        public string Get_ParametersPart(MethodBase methodBase)
        {
            var parameters = methodBase.GetParameters();

            var output = this.Get_ParametersPart(parameters);
            return output;
        }

        public string Get_ParametersPart(ParameterInfo[] parameters)
        {
            if (!parameters.Any())
            {
                // No parameters means no parentheses.
                return String.Empty;
            }

            var parameterTypes = Instances.StringOperator.Join(
                Instances.TokenSeparators.ArgumentListSeparator,
                parameters
                    .Select(parameter =>
                    {
                        var output = Instances.ParameterInfoOperator.Get_NamespacedTypeName_ForParameter(parameter);
                        return output;
                    }
                ));

            var output = $"{Instances.TokenSeparators.ParameterListOpenTokenSeparator}{parameterTypes}{Instances.TokenSeparators.ParameterListCloseTokenSeparator}";
            return output;
        }
    }
}
