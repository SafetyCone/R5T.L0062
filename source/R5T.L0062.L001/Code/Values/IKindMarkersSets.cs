using System;
using System.Collections.Generic;

using R5T.T0131;
using R5T.T0143;


namespace R5T.L0062.L001
{
    [ValuesMarker]
    public partial interface IKindMarkersSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IKindMarkersSets _Raw => Raw.KindMarkersSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IKindMarkersSets.N_000"/>
        public char[] All_AsArray => _Raw.N_000;

        private static readonly Lazy<HashSet<char>> zAll_Hash = new Lazy<HashSet<char>>(() => new HashSet<char>(new[]
        {
            IKindMarkers.Error_Constant,
            IKindMarkers.Event_Constant,
            IKindMarkers.Field_Constant,
            IKindMarkers.Method_Constant,
            IKindMarkers.Namespace_Constant,
            IKindMarkers.Property_Constant,
            IKindMarkers.Type_Constant,
        }));

        public HashSet<char> All_AsHash => zAll_Hash.Value;

        /// <summary>
        /// Chooses <see cref="All_AsHash"/> as the default.
        /// </summary>
        public HashSet<char> All => this.All_AsHash;
    }
}
