using System;


namespace R5T.L0062.F001
{
    public class IdentityStringOperator : IIdentityStringOperator
    {
        #region Infrastructure

        public static IIdentityStringOperator Instance { get; } = new IdentityStringOperator();


        private IdentityStringOperator()
        {
        }

        #endregion
    }
}

namespace R5T.L0062.F001.Platform
{
    public class IdentityStringOperator : IIdentityStringOperator
    {
        #region Infrastructure

        public static IIdentityStringOperator Instance { get; } = new IdentityStringOperator();


        private IdentityStringOperator()
        {
        }

        #endregion
    }
}
