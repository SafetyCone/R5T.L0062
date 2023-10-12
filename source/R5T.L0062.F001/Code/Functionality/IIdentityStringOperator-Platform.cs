using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.L0062.F001.Platform
{
    [FunctionalityMarker]
    public partial interface IIdentityStringOperator : IFunctionalityMarker,
        F000.IIdentityStringOperator
    {
        public string Append_MethodTypeParametersCount(
            string methodName,
            MethodInfo methodInfo)
        {
            // Add the method type parameter count.
            var typeParametersCount = Instances.MethodInfoOperator.Get_TypeParameterCount(methodInfo);

            methodName += $"{Instances.TokenSeparators.MethodTypeParameterCountTokenSeparator}{typeParametersCount}";
            return methodName;
        }

        public string Get_IdentityString(MemberInfo memberInfo)
        {
            var output = Instances.MemberInfoOperator._Platform.Get_IdentityString(memberInfo);
            return output;
        }
    }
}
