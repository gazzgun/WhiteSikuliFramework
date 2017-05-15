using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteSikuliFramework.Common;
using WhiteSikuliFramework.PageObject.Base;

namespace WhiteSikuliFramework.PageObject.PageObjects
{
    public class Homepage : BasePage
    {
        protected override ISikuliSession Session => SikuliSetup.GetSession();

    }
}
