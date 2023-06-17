using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAutomationTests.Utilities.Constants.Selectors
{
    public static class SalesAndMarketingTabSelectors
    {
        public const string SalesAndMarketingTab = "#grouptab-1";
        public const string MenuTabSubElements = ".menu-tab-sub-list";
        public const string CreateButton = "[name='SubPanel_create']";
        public const string FirstNameInput = "#DetailFormfirst_name-input";
        public const string LastNameInput = "#DetailFormlast_name-input";
        public const string CategoryDropdown = "#DetailFormcategories-input";
        public const string CategoryInput = "#DetailFormcategories-input-search-text";
        public const string CategoryAddItemField = "#DetailFormcategories-input-search-filtadd-checkbox";
        public const string RoleDropdown = "##DetailFormbusiness_role-input-label";
        public const string RoleOption = "#DetailFormbusiness_role-input-popup .input-label:not(.option-check)";
        public const string SaveButton = "#DetailForm_save";
    }
}
