using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Wpf4Xbim.Sdk
{
    [Transaction(TransactionMode.Manual)]
    public class WPF4Xbim : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {       
            MainWindow wpf = new MainWindow();
            wpf.Show();
            return Result.Succeeded;
        }
    }
}
