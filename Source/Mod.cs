using ICities;

namespace ProfitableTourismMod
{
    public class Mod : IUserMod
    {
        public string Name
        {
            get { return "Profitable Tourism, Offices, and Industry"; }
        }

        public string Description
        {
            get { return "Helps you earn more from tourism, industry, and office space."; }
        }


        #region Options UI
        
        public void OnSettingsUI(UIHelperBase helper)
        {
            helper.AddDropdown(
                "Tourism income",
                PTM_Options.TourismIncomeMultipliersStr,
                PTM_Options.Instance.GetTourismIncomeMultiplierIndex(),
                TourismIncomeMultiplierOnSelected
                );

            helper.AddDropdown(
                "Taxi income",
                PTM_Options.TaxiIncomeMultipliersStr,
                PTM_Options.Instance.GetTaxiIncomeMultiplierIndex(),
                TaxiIncomeMultiplierOnSelected
                );
            helper.AddDropdown(
                "Office income",
                PTM_Options.OfficeIncomeMultipliersStr,
                PTM_Options.Instance.GetOfficeIncomeMultiplierIndex(),
                OfficeIncomeMultiplierOnSelected
                );
            helper.AddDropdown(
                "Industry income",
                PTM_Options.IndustryIncomeMultipliersStr,
                PTM_Options.Instance.GetIndustryIncomeMultiplierIndex(),
                IndustryIncomeMultiplierOnSelected
                );
        }

        private void TourismIncomeMultiplierOnSelected(int sel)
        {
            PTM_Options.Instance.TourismIncomeMultiplier = PTM_Options.TourismIncomeMultipliers[sel];
            PTM_Options.Instance.Save();
        }

        private void TaxiIncomeMultiplierOnSelected(int sel)
        {
            PTM_Options.Instance.TaxiIncomeMultiplier = PTM_Options.TaxiIncomeMultipliers[sel];
            PTM_Options.Instance.Save();
        }

        private void OfficeIncomeMultiplierOnSelected(int sel)
        {
            PTM_Options.Instance.OfficeIncomeMultiplier = PTM_Options.OfficeIncomeMultipliers[sel];
            PTM_Options.Instance.Save();
        }
        private void IndustryIncomeMultiplierOnSelected(int sel)
        {
            PTM_Options.Instance.IndustryIncomeMultiplier = PTM_Options.IndustryIncomeMultipliers[sel];
            PTM_Options.Instance.Save();
        }

        #endregion
    }
}
