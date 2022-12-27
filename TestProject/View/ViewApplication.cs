using Autodesk.Revit.UI;
using RevitMEPSpecification;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TestProject
{
    internal class ViewApplication : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location,
            iconsDirectoryPath = Path.GetDirectoryName(assemblyLocation) + @"\icons\",
            tabName = "Спецификации";
            
            application.CreateRibbonTab(tabName);

            RibbonPanel panel = application.CreateRibbonPanel(tabName, "Redomine");


            PushButtonData buttonData = new PushButtonData(nameof(RebildSpecification), "Приветствие", assemblyLocation, typeof(RebildSpecification).FullName);

            {
                BitmapImage Icon = new BitmapImage(new Uri(iconsDirectoryPath + "icon.png"));
            };

            panel.AddItem(buttonData);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }


    }
}
