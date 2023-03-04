using Autodesk.Revit.UI;
using ExternalApplication;

namespace ExampleCreateUIApp
{
    public class RoutingApp : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            Information.AssemblyName =
                @"C:\Users\Admin\Desktop\workSpace\csharp\externalApplication\ExampleCreateUIApp\bin\Debug\ExampleCreateUIApp.dll";
            CreateUIApp.CreateUI<SonnyTab>(application);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }
}