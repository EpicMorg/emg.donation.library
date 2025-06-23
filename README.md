# EpicMorg Donation Library

Donation popup for WinForms (.NET 2.0–9.0)

## Example

```
using emg.donation.library;

string AppId = "emg.donation.library.net.test";
int AppPostponedDays = 7;

// automaticly show (on startup)
DonationStartup.ShowOnce(AppId, AppPostponedDays);

// show on button press without delay logic
var form = new FormDonate(testAppId, Convert.ToInt32(testAppPause));
form.ShowDialog();

```


## Docs

AppId - id string for target app
AppPostponedDays - Days to show windows again if checkbox "Never show" was not checked.
