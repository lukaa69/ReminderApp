namespace ReminderApp
{
    public partial class ReminderDetailPage : ContentPage
    {
        private Reminder _reminder;

        public ReminderDetailPage(Reminder reminder)
        {
            InitializeComponent();
            _reminder = reminder;
            titleLabel.Text = _reminder.Title;
            descriptionLabel.Text = _reminder.Description;
        }

        private async void OnDeleteReminderClicked(object sender, EventArgs e)
        {
            App.Reminders.Remove(_reminder);
            await Navigation.PopAsync();
        }
    }
}
