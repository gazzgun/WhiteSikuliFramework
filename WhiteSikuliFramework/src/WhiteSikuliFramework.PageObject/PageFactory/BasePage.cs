using SikuliSharp;

namespace WhiteSikuliFramework.PageObject.Base
{
    public abstract class BasePage
    {
        protected virtual  ISikuliSession Session { get; }
    }
}
