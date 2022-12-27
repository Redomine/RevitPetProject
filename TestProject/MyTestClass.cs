using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitMEPSpecification
{
    [Transaction(TransactionMode.Manual)]
    public class RebildSpecification : IExternalCommand
    {
        
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Приветствие", "Привет мир");

            return Result.Succeeded;
        }
    }
}
