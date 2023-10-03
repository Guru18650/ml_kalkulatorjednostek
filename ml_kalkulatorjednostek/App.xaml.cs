using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace ml_kalkulatorjednostek
{
    public partial class App : Application
    {
        public static ObservableCollection<Obliczenie> historiaList = new ObservableCollection<Obliczenie>();

        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;
            MainPage = new AppShell();
            historiaList = JsonConvert.DeserializeObject<ObservableCollection<Obliczenie>>(Preferences.Get("dane", "[]"));
        }

        public static void DodajObliczenie(string obliczenie, string wynik)
        {
            historiaList.Add(new Obliczenie { OpisObliczenia = obliczenie, WynikObliczenia = wynik });
            Preferences.Set("dane",JsonConvert.SerializeObject(historiaList));
        }
    }

    public class Obliczenie
    {
        public string OpisObliczenia { get; set; }
        public string WynikObliczenia { get; set; }
    }
}