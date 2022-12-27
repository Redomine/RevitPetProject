using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Application
    {
        public Result OnStartUp(UIControlledApplication application)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location,
                iconsDirPath = Path.GetDirectoryName(assemblyLocation) + @"\icons",
                tabName = "Тестовый проект";

            application.CreateRibbonTab(tabName);

            RibbonPanel panel = application.CreateRibbonPanel(tabName, "Первый плагин");

            PushButtonData buttonData = new PushButtonData(nameof(MyTestClass), "Приветствие", assemblyLocation, iconsDirPath);


        }
    }
}
