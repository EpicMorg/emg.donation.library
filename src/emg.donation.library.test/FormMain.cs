using System;
using System.Windows.Forms;
using emg.donation.library;

namespace emg.donation.library.net20.test
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string testAppId = "emg.donation.library.net20.test";
        string testAppFlag = "NeverShowAgain.flag";
        string testPropFlag = "PostponedDays.flag";
        decimal testAppPause = 0;

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FlagManager.FileExists(testAppId, testAppFlag))
            {
                buttonEmulate.Visible = false;
                numericUpDownDays.Visible = false;
            }

            DonationStartup.ShowOnce(testAppId, Convert.ToInt32(testAppPause));
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var form = new FormDonate(testAppId, Convert.ToInt32(testAppPause));
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emg.donation.library.FlagManager.DeleteFlag(testAppId, testAppFlag);
            emg.donation.library.FlagManager.DeleteFlag(testAppId, testPropFlag);
            MessageBox.Show("Flags removed! Application will be restarted",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Restart();
        }

        private void buttonEmulate_Click(object sender, EventArgs e)
        {
            emg.donation.library.FlagManager.DeleteFlag(testAppId, testPropFlag);
            DonationStartup.ShowOnce(testAppId, Convert.ToInt32(testAppPause));
        }

        private void numericUpDownDays_ValueChanged(object sender, EventArgs e)
        {
            testAppPause = numericUpDownDays.Value;
        }
    }
}
