using ReminderApp.Models;

namespace ReminderApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		MedicationList.ItemsSource = new List<Medication>
		{
			new Medication { Name = "Metformin", Time = "8:00 AM"},
            new Medication { Name = "Lisinopril", Time = "8:00 AM"},
            new Medication { Name = "Atorvastatin", Time = "8:00 PM"}
        };
	}
}
