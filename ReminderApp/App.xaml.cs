using System.Collections.ObjectModel;

namespace ReminderApp
{
    public partial class App : Application
    {
        public static ObservableCollection<Reminder> Reminders { get; private set; } = new ObservableCollection<Reminder>();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }

}
