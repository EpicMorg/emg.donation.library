using System;
using System.Windows.Forms;

namespace emg.donation.library
{
    public static class DonationStartup
    {
        public static void ShowOnce(string appId)
        {
            ShowOnce(appId, 7);
        }

        /// <summary>
        /// Shows the FormDonate window once for the given appId.
        /// If the folder already has the NeverShowAgain.flag flag, it does nothing.
        /// </summary>
        public static void ShowOnce(string appId, int postponeDays)
        {
            if (FlagManager.FileExists(appId, "NeverShowAgain.flag"))
                return;

            var until = FlagManager.ReadFlagDate(appId, "PostponedDays.flag");
            if (until.HasValue && until.Value > DateTime.Now)
                return;

            using (var form = new FormDonate(appId, postponeDays))
            {
                form.ShowDialog();
            }
        }
    }
}