namespace ml_kalkulatorjednostek;

public partial class Pamiec : ContentPage
{
	public Pamiec()
	{
		InitializeComponent();
		fPick.SelectedIndex = 0;
		tPick.SelectedIndex = 0;
	}

    private void calc_Clicked(object sender, EventArgs e)
    {
		int from = fPick.SelectedIndex*3;
		int to = tPick.SelectedIndex*3;
		if (String.IsNullOrEmpty(count.Text))
		{
			DisplayAlert("B³¹d", "Uzupe³nij wszystkie dane", "OK");
		} else
		{
            double cnt = double.Parse(count.Text);
			double kb = cnt * Math.Pow(10, from)/Math.Pow(10, to);
            string obliczenie = $"Przelicz {cnt} {fPick.SelectedItem}y na {tPick.SelectedItem}y";
            string wynikText = $"Wynik: {kb.ToString()} {tPick.SelectedItem}y";

            App.DodajObliczenie(obliczenie, wynikText);

            DisplayAlert("Wynik", $"{cnt} {fPick.SelectedItem}ów jest równe {kb} {tPick.SelectedItem}ów", "OK");

        }
    }
}