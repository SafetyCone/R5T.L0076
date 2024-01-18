using System;

using R5T.T0137;
using R5T.T0233;


namespace R5T.L0076.T000
{
    [ContextImplementationMarker, ContextTypeMarker]
    public class ProjectContext : IProjectContext
    {
        public IProjectFilePath ProjectFilePath { get; }

        string T0234.IHasProjectFilePath.ProjectFilePath => this.ProjectFilePath.Value;


        public ProjectContext(IProjectFilePath projectFilePath)
        {
            this.ProjectFilePath = projectFilePath;
        }
    }
}
