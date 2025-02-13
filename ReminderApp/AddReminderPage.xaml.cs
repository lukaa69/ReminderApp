namespace ReminderApp;

public partial class AddReminderPage : ContentPage
{
    public AddReminderPage()
    {
        InitializeComponent();
    }

    private async void OnSaveReminderClicked(object sender, EventArgs e)
    {
        var reminder = new Reminder
        {
            Title = titleEntry.Text,
            Description = descriptionEditor.Text
        };
        App.Reminders.Add(reminder);
        await Navigation.PopAsync();
    }
}