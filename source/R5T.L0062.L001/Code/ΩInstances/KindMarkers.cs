using System;


namespace R5T.L0062.L001
{
    public class KindMarkers : IKindMarkers
    {
        #region Infrastructure

        public static IKindMarkers Instance { get; } = new KindMarkers();


        private KindMarkers()
        {
        }

        #endregion
    }
}
