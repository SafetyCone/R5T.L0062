using System;


namespace R5T.L0062.F001
{
    public class TokenSeparators : ITokenSeparators
    {
        #region Infrastructure

        public static ITokenSeparators Instance { get; } = new TokenSeparators();


        private TokenSeparators()
        {
        }

        #endregion
    }
}
