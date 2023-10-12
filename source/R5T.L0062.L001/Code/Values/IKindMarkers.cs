using System;

using R5T.T0131;


namespace R5T.L0062.L001
{
    [ValuesMarker]
    public partial interface IKindMarkers : IValuesMarker
    {
        /// <summary>
        /// <para>'!' (exclamation point)</para>
        /// </summary>
        public const char Error_Constant = '!';

        /// <inheritdoc cref="Error_Constant"/>
        public char Error => Error_Constant;

        /// <summary>
        /// <para>'E' (capital E)</para>
        /// </summary>
        public const char Event_Constant = 'E';

        /// <inheritdoc cref="Event_Constant"/>
        public char Event => Event_Constant;

        /// <summary>
        /// <para>'F' (capital F)</para>
        /// </summary>
        public const char Field_Constant = 'F';

        /// <inheritdoc cref="Field_Constant"/>
        public char Field => Field_Constant;

        /// <summary>
        /// <para>'M' (capital M)</para>
        /// </summary>
        public const char Method_Constant = 'M';

        /// <inheritdoc cref="Method_Constant"/>
        public char Method => Method_Constant;

        /// <summary>
        /// <para>'N' (capital N)</para>
        /// </summary>
        public const char Namespace_Constant = 'N';

        /// <inheritdoc cref="Namespace_Constant"/>
        public char Namespace => Namespace_Constant;

        /// <summary>
        /// <para>'P' (capital P)</para>
        /// </summary>
        public const char Property_Constant = 'P';

        /// <inheritdoc cref="Property_Constant"/>
        public char Property => Property_Constant;

        /// <summary>
        /// <para>'T' (capital T)</para>
        /// </summary>
        public const char Type_Constant = 'T';

        /// <inheritdoc cref="Type_Constant"/>
        public char Type => Type_Constant;
    }
}
