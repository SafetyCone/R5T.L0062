using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.L0062.F001
{
    [FunctionalityMarker]
    public partial interface IParameterInfoOperator : IFunctionalityMarker,
        L0053.IParameterInfoOperator
    {
        public string Get_NamespacedTypeName_ForParameter(ParameterInfo parameterInfo)
        {
            var typeNamespacedTypeName = Instances.TypeOperator.Get_NamespacedTypeName_ForParameterType(parameterInfo.ParameterType);

            var output = typeNamespacedTypeName;

            // Adjust for mismatch in by-reference marker character between MemberInfo.Name ('&') and the identity name ('@')s.
            var isByRef = this.Is_ByReference(parameterInfo);
            if (isByRef)
            {
                output = output[..^1] + Instances.TypeNameAffixes.ByReference_Suffix;
            }

            // Special behavior for parameters of implicit and explicit conversion operators on generic types.
            if (parameterInfo.Member is MethodInfo methodInfo)
            {
                var isConversionOperator = Instances.MethodInfoOperator.Is_ConversionOperator(methodInfo);
                if (isConversionOperator)
                {
                    var parameterType = parameterInfo.ParameterType;

                    // Parameters of conversion operators on generic types seem to use the parameter type name ("T") instead of the positional type name ("`0").
                    if (parameterInfo.ParameterType.IsGenericTypeParameter)
                    {
                        output = Instances.TypeOperator.Handle_ConversionOperatorGenericTypeName(
                            parameterType,
                            output);
                    }

                    // Handle arrays of generic types.
                    if (parameterInfo.ParameterType.HasElementType)
                    {
                        var elementType = parameterInfo.ParameterType.GetElementType();

                        if (elementType.IsGenericTypeParameter)
                        {
                            output = Instances.TypeOperator.Handle_ConversionOperatorGenericTypeName(
                                elementType,
                                output);
                        }
                    }
                }
            }

            return output;
        }
    }
}
