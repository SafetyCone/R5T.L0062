using System;


namespace R5T.L0062.F001
{
    public class TypeNameAffixes : ITypeNameAffixes
    {
        #region Infrastructure

        public static ITypeNameAffixes Instance { get; } = new TypeNameAffixes();


        private TypeNameAffixes()
        {
        }

        #endregion
    }
}
