using System;


namespace R5T.L0062.L001
{
    public class KindMarkerOperator : IKindMarkerOperator
    {
        #region Infrastructure

        public static IKindMarkerOperator Instance { get; } = new KindMarkerOperator();


        private KindMarkerOperator()
        {
        }

        #endregion
    }
}
