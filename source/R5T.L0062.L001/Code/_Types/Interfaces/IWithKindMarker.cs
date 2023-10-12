using System;

using R5T.T0142;


namespace R5T.L0062.L001
{
    [DataTypeMarker]
    public interface IWithKindMarker :
        IHasKindMarker
    {
        new char KindMarker { get; set; }
    }
}
