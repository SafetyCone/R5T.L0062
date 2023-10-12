using System;

using R5T.T0131;


namespace R5T.L0062.L001
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker
    {
        /// <summary>
        /// <para>':' (colon)</para>
        /// Separates the first character (which is the kind marker_ from the rest of the identity name (which is the identity name value).
        /// </summary>
        public const char KindMarkerTokenSeparator_Constant = ':';

        /// <inheritdoc cref="KindMarkerTokenSeparator_Constant"/>
        public char KindMarkerTokenSeparator => KindMarkerTokenSeparator_Constant;
    }
}
