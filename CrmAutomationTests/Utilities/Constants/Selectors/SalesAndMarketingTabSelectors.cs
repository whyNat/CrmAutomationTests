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
        public const string MainTitle = "#main-title-module";
        public const string ContactsSidebarSection = "#left-sidebar a";
        public const string CreateButton = ".card-header .listview-nav-block .input-button.first";
        public const string FirstNameInput = "#DetailFormfirst_name-input";
        public const string LastNameInput = "#DetailFormlast_name-input";
        public const string CategoryDropdown = "#DetailFormcategories-input";
        public const string CategoryInputs = "#DetailFormcategories-input-search-list .option-cell.input-label";
        public const string RoleDropdown = "#DetailFormbusiness_role-input-label";
        public const string RoleOption = "#DetailFormbusiness_role-input-popup .input-label:not(.option-check)";
        public const string SaveButton = "#DetailForm_save";

        public const string SavedFirstNameLastName = "#_form_header h3";
        public const string SavedCategories = ".summary-meta > ul > li:nth-child(1)";
        public const string SavedRole = ".cell-business_role .form-value";

        public const string SavedContact = ".listViewRow.oddListRowS1:nth-child(1) a";
    }
}
