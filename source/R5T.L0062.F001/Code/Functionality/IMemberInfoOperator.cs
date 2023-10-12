using System;
using System.Reflection;

using R5T.T0132;

using R5T.L0062.T000;
using R5T.L0062.T000.Extensions;


namespace R5T.L0062.F001
{
    /// <summary>
    /// Operations for getting identity strings.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IMemberInfoOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IMemberInfoOperator _Platform => Platform.MemberInfoOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public IIdentityString Get_IdentityString(MemberInfo memberInfo)
        {
            var output = _Platform.Get_IdentityString(memberInfo)
                .ToIdentityString();

            return output;
        }
    }
}
