using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPISamPle
{
    [Transaction(TransactionMode.Manual)]
    public class SetPrameterCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            
            SetParameterViewModel ViewModel= new SetParameterViewModel(uidoc);
            SetParameter window = new SetParameter(ViewModel);
            window.Show();


            return Result.Succeeded;
        }
    }
}
