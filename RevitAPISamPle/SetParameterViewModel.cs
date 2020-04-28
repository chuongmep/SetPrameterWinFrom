using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using RevitAPISamPle.LIb;

namespace RevitAPISamPle
{


   public class SetParameterViewModel : ViewModelBase
    {
       #region Public Properties

       public Document _doc;
       public UIDocument _uidoc;
       public Element _Element;

       #endregion

       #region Binding Properties

       public List<string> AllParameterName { get; set; }
       public List<Parameter> AllParameters { get; set; }

       public string SelectedParameter { get; set; }

       public string TxtStatus { get; set; }
       #endregion

       #region Contructor

       public SetParameterViewModel(Autodesk.Revit.UI.UIDocument uidoc)
       {
           _uidoc = uidoc;
           _doc = uidoc.Document;

           Reference r = _uidoc.Selection.PickObject(ObjectType.Element);
           Element e = _doc.GetElement(r);
           _Element = e;
           Process();
       }

        #endregion

       #region Process

       public void Process()
       {
           List<string> AllParametersName = GetAllParametersName(_Element, false);

           AllParameterName = AllParametersName.Distinct().ToList();
           AllParameterName.Sort();

           SelectedParameter = AllParameterName[0];

           AllParameters = GetAllParameters(_Element, false);
       }

       #endregion

       #region GetAllParametersName

       public static List<string> GetAllParametersName(Element el,
           bool isIncludeTypePara = true)
       {
           List<string> allParametersname = new List<string>();
           allParametersname.Add("ElementId");

           foreach (Parameter p in el.Parameters)
           {
               allParametersname.Add(p.Definition.Name);
           }

           if (isIncludeTypePara)
           {
               Element elementType = el.Document.GetElement(el.GetTypeId());

               if (elementType != null)
                   foreach (Parameter p in elementType.Parameters)
                       allParametersname.Add(p.Definition.Name);
           }

           return allParametersname;
       }

       #endregion

       #region GetAllParameter

       public static List<Parameter> GetAllParameters(Element el,
           bool isIncludeTypePara = true)
       {
           List<Parameter> pra = new List<Parameter>();
           foreach (Parameter p in el.Parameters)
           {
               pra.Add(p);
           }

           if (isIncludeTypePara)
           {
               Element elementType = el.Document.GetElement(el.GetTypeId());

               if (elementType != null)
                   foreach (Parameter p in elementType.Parameters)
                       pra.Add(p);
           }

           return pra.Distinct().ToList();
       }

       #endregion

       #region SetPrameter

       public void SetParameter()
       {
           foreach (Parameter p in AllParameters)
           {
               if (p.Definition.Name == SelectedParameter)
               {
                   using (Transaction tran = new Transaction(_doc))
                   {
                       tran.Start("Change");

                       Parameter Parameter = _Element.LookupParameter(SelectedParameter);
                       Parameter?.SetValue(TxtStatus);

                       tran.Commit();
                   }
               }
           }
       }

       #endregion
    }
}
