using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ReminderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            reminderListView.ItemsSource = App.Reminders;
        }

        private async void OnAddReminderClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddReminderPage());
        }

        private async void OnReminderSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var reminder = e.SelectedItem as Reminder;
            if (reminder != null)
            {
                await Navigation.PushAsync(new ReminderDetailPage(reminder));
            }
        }
    }



}
