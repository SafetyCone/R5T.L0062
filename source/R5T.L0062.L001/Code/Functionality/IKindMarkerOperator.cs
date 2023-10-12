using System;

using R5T.T0132;


namespace R5T.L0062.L001
{
    [FunctionalityMarker]
    public partial interface IKindMarkerOperator : IFunctionalityMarker
    {
        public string Make_KindMarked(
            string identityStringValue,
            char kindMarker)
        {
            var output = $"{kindMarker}{Instances.TokenSeparators.KindMarkerTokenSeparator}{identityStringValue}";
            return output;
        }

        public string Make_ErrorKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Error);

            return output;
        }

        public string Make_EventKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Event);

            return output;
        }

        public string Make_FieldKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Field);

            return output;
        }

        public string Make_MethodKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Method);

            return output;
        }

        public string Make_PropertyKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Property);

            return output;
        }

        public string Make_TypeKindMarked(string identityStringValue)
        {
            var output = this.Make_KindMarked(
                identityStringValue,
                Instances.KindMarkers.Type);

            return output;
        }
    }
}
