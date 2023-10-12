using System;


namespace R5T.L0062.F000
{
    public class MemberNameOperator : IMemberNameOperator
    {
        #region Infrastructure

        public static IMemberNameOperator Instance { get; } = new MemberNameOperator();


        private MemberNameOperator()
        {
        }

        #endregion
    }
}
