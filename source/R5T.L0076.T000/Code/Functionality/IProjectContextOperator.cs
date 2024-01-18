using System;

using R5T.T0132;
using R5T.T0233.Extensions;


namespace R5T.L0076.T000
{
    [FunctionalityMarker]
    public partial interface IProjectContextOperator : IFunctionalityMarker
    {
        public IProjectContext From(string projectFilePath)
        {
            var projectFilePath_StronglyTyped = projectFilePath.ToProjectFilePath();

            var output = new ProjectContext(projectFilePath_StronglyTyped);
            return output;
        }
    }
}
