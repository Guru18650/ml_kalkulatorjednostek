namespace ml_kalkulatorjednostek;

public partial class Pamiec : ContentPage
{
	public Pamiec()
	{
		InitializeComponent();
	}

    private void calc_Clicked(object sender, EventArgs e)
    {
		int from = fPick.SelectedIndex;
		int to = tPick.SelectedIndex;
		double cnt = double.Parse(count.Text);
    }
}