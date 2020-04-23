using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB.Analysis;
using Autodesk.Revit.UI;

namespace RevitAPISamPle
{
    [Transaction(TransactionMode.Manual)]
    class App : IExternalApplication
    {
        public const string tabname = "AddInSample";
        public const string panelName = "Tool";
        public const string buttonName = "Set Parameter";

        public readonly string helpPath = "http://chuongmep.com/";

        public readonly string Path = Assembly.GetExecutingAssembly().Location;

        public Result OnStartup(UIControlledApplication app)
        {
            
            app.CreateRibbonTab(tabname);

            RibbonPanel RibbonPanel = app.CreateRibbonPanel(tabname, panelName);


            PushButtonData PushButtonData = new PushButtonData(panelName,buttonName,Path, "RevitAPISamPle.SetPrameterCmd");
            PushButton PushButton = RibbonPanel.AddItem(PushButtonData) as PushButton;

            ContextualHelp ContextualHelp = new ContextualHelp(ContextualHelpType.Url,helpPath);
            PushButton.SetContextualHelp(ContextualHelp);

            BitmapImage BitmapImage = new BitmapImage(new Uri("Pack://application:,,,/RevitAPISamPle;component/Resources/icon.png"));
            PushButton.LargeImage = BitmapImage;

            return Result.Succeeded;

        }

        public Result OnShutdown(UIControlledApplication app)
        {
            return Result.Cancelled;
        }
    }
}
