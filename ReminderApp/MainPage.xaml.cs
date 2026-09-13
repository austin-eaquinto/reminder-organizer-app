namespace ReminderApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		MedicationList.ItemsSource = new List<string>
		{
			"Metformin - 8:00 AM",
			"Lisinopril - 8:00 AM",
			"Atorvastatin - 8:00 PM"
		};
	}
}
