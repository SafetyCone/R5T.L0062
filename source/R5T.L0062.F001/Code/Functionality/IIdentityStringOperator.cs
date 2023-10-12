using System;
using System.Reflection;

using R5T.T0132;

using R5T.L0062.T000;


namespace R5T.L0062.F001
{
    [FunctionalityMarker]
    public partial interface IIdentityStringOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IIdentityStringOperator _Platform => Platform.IdentityStringOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public IIdentityString Get_IdentityString(MemberInfo memberInfo)
        {
            var output = Instances.MemberInfoOperator.Get_IdentityString(memberInfo);
            return output;
        }
    }
}
