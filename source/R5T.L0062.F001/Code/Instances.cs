using System;


namespace R5T.L0062.F001
{
    public static class Instances
    {
        public static IExceptionMessageOperator ExceptionMessageOperator => F001.ExceptionMessageOperator.Instance;
        public static IExceptionOperator ExceptionOperator => F001.ExceptionOperator.Instance;
        public static L0053.IFlagsOperator FlagsOperator => L0053.FlagsOperator.Instance;
        public static IIdentityStringOperator IdentityStringOperator => F001.IdentityStringOperator.Instance;
        public static Z000.IKindMarkers KindMarkers => Z000.KindMarkers.Instance;
        public static L001.IKindMarkerOperator KindMarkerOperator => L001.KindMarkerOperator.Instance;
        public static IMemberInfoOperator MemberInfoOperator => F001.MemberInfoOperator.Instance;
        public static L0053.IMethodInfoOperator MethodInfoOperator => L0053.MethodInfoOperator.Instance;
        public static L0053.INamespacedTypeNameOperator NamespacedTypeNameOperator => L0053.NamespacedTypeNameOperator.Instance;
        public static IParameterInfoOperator ParameterInfoOperator => F001.ParameterInfoOperator.Instance;
        public static L0053.IPropertyInfoOperator PropertyInfoOperator => L0053.PropertyInfoOperator.Instance;
        public static L0053.IStringOperator StringOperator => L0053.StringOperator.Instance;
        public static ITokenSeparators TokenSeparators => F001.TokenSeparators.Instance;
        public static ITypeNameAffixes TypeNameAffixes => F001.TypeNameAffixes.Instance;
        public static L0053.ITypeNameOperator TypeNameOperator => L0053.TypeNameOperator.Instance;
        public static ITypeOperator TypeOperator => F001.TypeOperator.Instance;
    }
}