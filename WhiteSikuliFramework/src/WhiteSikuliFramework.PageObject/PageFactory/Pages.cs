using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteSikuliFramework.PageObject.PageObjects;

namespace WhiteSikuliFramework.PageObject.PageFactory
{
    public static class Pages
    {
        public static Homepage Homepage => GetPage<Homepage>();

        public static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }
    }
}
