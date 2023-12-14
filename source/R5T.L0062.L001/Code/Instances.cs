using System;


namespace R5T.L0062.L001
{
    public static class Instances
    {
        public static IKindMarkers KindMarkers => L001.KindMarkers.Instance;
        public static L0053.IStringOperator StringOperator => L0053.StringOperator.Instance;
        public static ITokenSeparators TokenSeparators => L001.TokenSeparators.Instance;
    }
}