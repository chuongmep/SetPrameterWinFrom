#region Namespaces

using System;
using System.Collections.Generic;
using System.Windows;
using Autodesk.Revit.DB;
using Application = Autodesk.Revit.ApplicationServices.Application;
using String = System.String;

#endregion

namespace RevitAPISamPle.LIb
{
    public static class ParameterUtils
    {
        
        /// <summary>
        /// Gán giá trị cho parameter p
        /// </summary>
        /// <param name="p">Parameter cần xét giá trị.</param>
        /// <param name="value">Giá trị cần set cho parameter p.</param>
        public static void SetValue(this Parameter p, object value)
        {
            // Cannot edit readonly
            if (p.IsReadOnly || value == null) return;

            switch (p.StorageType)
            {
                case StorageType.Double:
                    p.Set(Convert.ToDouble(value));
                    break;

                case StorageType.ElementId:
                    if (value is string)
                    {
                        try
                        {
                            int id = Convert.ToInt32(value);
                            p.Set(new ElementId(id));
                            break;
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                    p.Set(value as ElementId);
                    break;

                case StorageType.Integer:
                    p.Set(Convert.ToInt32(value));
                    break;

                case StorageType.String:
                    p.Set(value.ToString());
                    break;

                case StorageType.None:
                    p.SetValueString(value as string);
                    break;
            }
        }
    }
}