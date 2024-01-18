using System;


namespace R5T.L0076.Construction
{
    public class Instances :
        L0055.Instances
    {
        public static F000.IProjectContextOperator ProjectContextOperator => F000.ProjectContextOperator.Instance;
        public static O001.IProjectContextOperations ProjectContextOperations => O001.ProjectContextOperations.Instance;
        public static O0029.IProjectXElementOperationSets ProjectXElementOperationSets => O0029.ProjectXElementOperationSets.Instance;
        public static L0032.F001.IPropertyGroupXElementOperations PropertyGroupXElementOperations => L0032.F001.PropertyGroupXElementOperations.Instance;
        public static L0032.F003.IValues Values => L0032.F003.Values.Instance;
    }
}