using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPISamPle
{
  internal  class SetParameterEvent  : IExternalEventHandler

  {
      public SetParameterViewModel viewModel { get; set; }
      public void Execute(UIApplication uiapp)
      {
          Document doc = uiapp.ActiveUIDocument.Document;

          viewModel.SetParameter();
      }

      public string GetName()
      {
          return "SetParameter";
      }
    }
}
