using System;


namespace R5T.L0076.O001
{
    public class ProjectContextOperations : IProjectContextOperations
    {
        #region Infrastructure

        public static IProjectContextOperations Instance { get; } = new ProjectContextOperations();


        private ProjectContextOperations()
        {
        }

        #endregion
    }
}
