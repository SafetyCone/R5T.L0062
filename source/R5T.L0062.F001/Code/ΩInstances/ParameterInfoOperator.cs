using System;


namespace R5T.L0062.F001
{
    public class ParameterInfoOperator : IParameterInfoOperator
    {
        #region Infrastructure

        public static IParameterInfoOperator Instance { get; } = new ParameterInfoOperator();


        private ParameterInfoOperator()
        {
        }

        #endregion
    }
}
