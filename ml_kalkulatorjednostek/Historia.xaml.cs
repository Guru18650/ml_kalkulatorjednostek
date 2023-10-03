using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ml_kalkulatorjednostek
{
    public partial class Historia : ContentPage
    {

        public Historia()
        {
            InitializeComponent();
            historyListView.ItemsSource = App.historiaList;
        }

        private async void clean_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Uwaga", "Czy jesteœ pewny?", "TAK", "NIE"))
            {
                Preferences.Set("dane", "[]");
                App.historiaList.Clear();
            }
        }
    }

   
}