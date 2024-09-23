using System;


namespace R5T.L0062.L001
{
    public class KindMarkersSets : IKindMarkersSets
    {
        #region Infrastructure

        public static IKindMarkersSets Instance { get; } = new KindMarkersSets();


        private KindMarkersSets()
        {
        }

        #endregion
    }
}


namespace R5T.L0062.L001.Raw
{
    public class KindMarkersSets : IKindMarkersSets
    {
        #region Infrastructure

        public static IKindMarkersSets Instance { get; } = new KindMarkersSets();


        private KindMarkersSets()
        {
        }

        #endregion
    }
}