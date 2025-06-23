using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace emg.donation.library
{
    public partial class FormDonate : Form
    {
        private readonly string _appId;
        private readonly int _postponeDays;
        private readonly int toolTipDuration = 1000;

        public FormDonate(string appId, int postponeDays)
        {
            _appId = appId;
            _postponeDays = postponeDays;
            InitializeComponent();
            this.FormClosing += FormDonate_FormClosing;
        }

        private void FormDonate_Load(object sender, EventArgs e)
        {
            if (FlagManager.FileExists(_appId, "NeverShowAgain.flag"))
            {
                checkBoxNeverShowAgain.Visible = false;
                checkBoxNeverShowAgain.Checked = true;
                checkBoxNeverShowAgain.Enabled = false;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region donationBtns

        private void buttonPatreon_Click(object sender, EventArgs e)
        {
            Process.Start(buttonPatreon.Tag.ToString());
        }

        private void buttonKoFi_Click(object sender, EventArgs e)
        {
            Process.Start(buttonKoFi.Tag.ToString());
        }

        private void buttonBoosty_Click(object sender, EventArgs e)
        {
            Process.Start(buttonBoosty.Tag.ToString());
        }
        private void buttonEpicMorg_Click(object sender, EventArgs e)
        {
            Process.Start(buttonEpicMorg.Tag.ToString());
        }
        #endregion
        #region donationPics
        private void pictureBoxTon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxTon.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxTon), textBoxTon, toolTipDuration);
        }

        private void pictureBoxETH_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxETH.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxETH), textBoxETH, toolTipDuration);
        }

        private void pictureBoxBTC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxBTC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxBTC), textBoxBTC, toolTipDuration);
        }

        private void pictureBoxLTC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxLTC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxLTC), textBoxLTC, toolTipDuration);
        }

        private void pictureBoxNVC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxNVC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxNVC), textBoxNVC, toolTipDuration);
        }

        private void pictureBoxDOGE_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDOGE.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxDOGE), textBoxDOGE, toolTipDuration);
        }

        private void pictureBoxPRC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPRC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxPRC), textBoxPRC, toolTipDuration);
        }

        private void pictureBoxRVC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxRVC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxRVC), textBoxRVC, toolTipDuration);
        }

        private void pictureBoxZEC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxZEC.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxZEC), textBoxZEC, toolTipDuration);
        }

        private void pictureBoxXMR_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxXMR.Text);
            toolTip.Show(toolTip.GetToolTip(textBoxXMR), textBoxXMR, toolTipDuration);
        }
        #endregion

        private void FormDonate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxNeverShowAgain.Checked)
            {
                FlagManager.WriteFlag(_appId, "NeverShowAgain.flag");
            }
            else
            {
                var next = DateTime.Now.AddDays(_postponeDays);
                FlagManager.WriteFlag(_appId, "PostponedDays.flag", next.ToString("o"));
            }
        }
    }

}
