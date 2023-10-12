using System;


namespace R5T.L0062.F000
{
    public static class Instances
    {
        public static T0221.IElementTypeRelationshipOperator ElementTypeRelationshipOperator => T0221.ElementTypeRelationshipOperator.Instance;
        public static L001.IKindMarkerOperator KindMarkerOperator => L001.KindMarkerOperator.Instance;
        public static IMemberNameOperator MemberNameOperator => F000.MemberNameOperator.Instance;
        public static L0053.IStringOperator StringOperator => L0053.StringOperator.Instance;
        public static ITokenSeparators TokenSeparators => F000.TokenSeparators.Instance;
        public static ITypeNameAffixes TypeNameAffixes => F000.TypeNameAffixes.Instance;
    }
}