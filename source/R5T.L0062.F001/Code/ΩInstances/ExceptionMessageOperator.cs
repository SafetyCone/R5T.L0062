using System;


namespace R5T.L0062.F001
{
    public class ExceptionMessageOperator : IExceptionMessageOperator
    {
        #region Infrastructure

        public static IExceptionMessageOperator Instance { get; } = new ExceptionMessageOperator();


        private ExceptionMessageOperator()
        {
        }

        #endregion
    }
}
