using System;

using R5T.T0131;


namespace R5T.L0062.L001.Raw
{
    [ValuesMarker]
    public partial interface IKindMarkersSets : IValuesMarker
    {
        /// <summary>
        /// All kind markers.
        /// </summary>
        public char[] N_000 => new[]
        {
            Instances.KindMarkers._ExclamationPoint,
            Instances.KindMarkers._E,
            Instances.KindMarkers._F,
            Instances.KindMarkers._M,
            Instances.KindMarkers._N,
            Instances.KindMarkers._P,
            Instances.KindMarkers._T
        };
    }
}
