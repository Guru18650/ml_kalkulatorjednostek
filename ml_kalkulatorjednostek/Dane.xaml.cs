namespace ml_kalkulatorjednostek;

public partial class Dane : ContentPage
{
	public Dane()
	{
		InitializeComponent();
	}


    private void calc1_Clicked(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(time1.Text) || String.IsNullOrEmpty(bandwidth1.Text))
        {
            DisplayAlert("B³¹d", "Uzupe³nij wszystkie dane", "OK");
        }
        else
        {
            double hours = double.Parse(time1.Text);
            double bandwidthMbPerSec = double.Parse(bandwidth1.Text) / 8;
            double dataDownloaded = hours * 3600 * bandwidthMbPerSec / 1024;
            dataDownloaded = Math.Round(dataDownloaded, 2);

            string obliczenie = $"Pobrane dane w {hours} godzin, przy ³¹czu {bandwidth1.Text} Mb/s";
            string wynikText = $"Wynik: {dataDownloaded} GB.";

            App.DodajObliczenie(obliczenie, wynikText);

            DisplayAlert("Wynik", $"W czasie {hours} godzin, przez ³¹cze o przepustowoœci {bandwidth1.Text} Mb/s pobierzemy ok. {dataDownloaded} GB.", "OK");
        }
    }

    private void calc2_Clicked(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(fileSize2.Text) || String.IsNullOrEmpty(bandwidth2.Text))
        {
            DisplayAlert("B³¹d", "Uzupe³nij wszystkie dane", "OK");
        }
        else
        {
            double fileSizeGB = double.Parse(fileSize2.Text);
            double bandwidthMbPerSec = double.Parse(bandwidth2.Text) / 8;
            double timeInSeconds = (fileSizeGB * 1024) / bandwidthMbPerSec;
            TimeSpan timeSpan = TimeSpan.FromSeconds(timeInSeconds);

            int minutes = (int)timeSpan.TotalMinutes;
            int seconds = timeSpan.Seconds;

            string obliczenie = $"Czas pobierania {fileSizeGB} GB, przy ³¹czu {bandwidth1.Text} Mb/s";
            string wynikText = $"Wynik: {minutes} minut {seconds} sekund.";

            App.DodajObliczenie(obliczenie, wynikText);

            DisplayAlert("Wynik", $"Plik o wielkoœci {fileSizeGB} GB, przez ³¹cze o przepustowoœci {bandwidth2.Text} Mb/s pobierzemy w oko³o {minutes} minut {seconds} sekund.", "OK");
        }
    }
}