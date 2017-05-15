using System.IO;
using WhiteSikuliFramework.Common;

namespace WhiteSikuliFramework.PageObject
{
    public static class TestBase
    {
        public static void TestSetup(string title, string path)
        {
            WindowDriver.ApplicationPath = ApplicationSettings.GetApplicationPath(path);
            WindowDriver.ApplicationTitle = ApplicationSettings.GetApplicationTitle(title);

            if (WindowDriver.Window == null)
                WindowDriver.GrabWindow();
        }

        public static void TearDown()
        {
            WindowDriver.CloseApplication();
            WindowDriver.Window = null;
        }

        public static void DeleteDbFiles()
        {
            var dir = new DirectoryInfo(@"C:\Users\TechTeam\Documents\Uniface 97 Development\project\dbms");
            foreach (var file in dir.GetFiles())
                try
                {
                    file.Delete();
                }
                catch (IOException)
                {
                }
        }
    }
}