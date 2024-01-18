using System;

using R5T.T0141;


namespace R5T.L0076.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// Shows how to create a project file using an enumerable of actions on the project XElment, from an action in an enumerable of actions on an IHasProjectFilePath project context.
        /// </summary>
        public void Create_ProjectFile()
        {
            /// Inputs.
            var projectFilePath = Instances.FilePaths.Sample_ProjectFilePath;
            var projectDescription =
                //Instances.Values.DescriptionForProject_Default
                Instances.Values.DescriptionForProject_Example
                ;
            var author = "DCoats";

            /// Run.
            Instances.ProjectContextOperator.In_ProjectContext(
                projectFilePath.Value,
                Instances.ProjectContextOperations.Create_ProjectFile_Synchronous(
                    Instances.ProjectXElementOperationSets.BlazorWebAssemblyClient_Net_8(
                        projectDescription,
                        author,
                        Instances.PropertyGroupXElementOperations.Set_RepositoryUrl("https://github.com/SafetyCone/R5T.F0069.git")
                    )
                )
            );

            Instances.NotepadPlusPlusOperator.Open(projectFilePath);
        }
    }
}
