using System;


namespace R5T.L0062.L001
{
    public static class Instances
    {
        public static IKindMarkerOperator KindMarkerOperator => L001.KindMarkerOperator.Instance;
        public static IKindMarkers KindMarkers => L001.KindMarkers.Instance;
        public static IKindMarkersSets KindMarkersSets => L001.KindMarkersSets.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
        public static L0066.ISwitchOperator SwitchOperator => L0066.SwitchOperator.Instance;
        public static ITokenSeparators TokenSeparators => L001.TokenSeparators.Instance;
    }
}