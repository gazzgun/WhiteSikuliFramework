using System.Windows.Automation;
using TestStack.White.UIItems.Finders;

namespace WhiteSikuliFramework.Common
{
    /// <summary>
    ///     This class is responsible for the different search criteria function.
    /// </summary>
    public class SearchCriteriaHelper
    {
        //Need To Modify This Area

        #region Search Criteria

        public static SearchCriteria SearchByID(string id)
        {
            return SearchCriteria.ByAutomationId(id);
        }

        public static SearchCriteria SearchByClassName(string name)
        {
            return SearchCriteria.ByClassName(name);
        }

        public static SearchCriteria SearchByFramework(string framework)
        {
            return SearchCriteria.ByFramework(framework);
        }

        public static SearchCriteria SearchByText(string text)
        {
            return SearchCriteria.ByText(text);
        }

        public static SearchCriteria SearchByControlType(ControlType controlType)
        {
            return SearchCriteria.ByControlType(controlType);
        }

        #endregion
    }
}