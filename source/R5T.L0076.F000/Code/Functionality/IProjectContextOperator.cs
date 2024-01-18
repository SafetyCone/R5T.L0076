using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;

using R5T.L0076.T000;


namespace R5T.L0076.F000
{
    [FunctionalityMarker]
    public partial interface IProjectContextOperator : IFunctionalityMarker,
        T000.IProjectContextOperator
    {
        public void In_ProjectContext(
            string projectFilePath,
            IEnumerable<Action<IProjectContext>> actions)
        {
            var directoryPathContext = this.From(projectFilePath);

            Instances.ContextOperator.In_Context(
                directoryPathContext,
                actions);
        }

        public void In_ProjectContext(
            string projectFilePath,
            params Action<IProjectContext>[] actions)
        {
            this.In_ProjectContext(
                projectFilePath,
                actions.AsEnumerable());
        }
    }
}
