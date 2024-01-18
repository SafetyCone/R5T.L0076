using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.T0131;
using R5T.T0234;


namespace R5T.L0076.O001
{
    [ValuesMarker]
    public partial interface IProjectContextOperations : IValuesMarker
    {
        //public async Task Create_ProjectFile(
        //    IHasProjectFilePath context,
        //    IEnumerable<Action<XElement>> projectElementActions)
        //{
        //    var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement();

        //    Instances.ContextOperator.In_Context(
        //        projectElement,
        //        projectElementActions);

        //    await Instances.ProjectXElementOperator.To_File_Separated(
        //        context.ProjectFilePath,
        //        projectElement);
        //}

        public Action<IHasProjectFilePath> Create_ProjectFile_Synchronous(
            IEnumerable<Action<XElement>> projectElementActions)
        {
            return context =>
            {
                var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement();

                Instances.ContextOperator.In_Context(
                    projectElement,
                    projectElementActions);

                Instances.ProjectXElementOperator.To_File_Separated_Synchronous(
                    context.ProjectFilePath,
                    projectElement);
            };
        }
    }
}
