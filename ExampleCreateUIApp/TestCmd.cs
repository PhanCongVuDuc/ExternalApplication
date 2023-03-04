using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;
using ExternalApplication;
using System;
using System.IO;

namespace ExampleCreateUIApp
{
    [Transaction(TransactionMode.Manual)]
    public class TestCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            MessageBox.Show("Hello Sonny");

            return Result.Succeeded;
        }
    }
}