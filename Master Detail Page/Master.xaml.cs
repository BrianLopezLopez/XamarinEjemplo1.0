using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Master_Detail_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnMotos_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Motos());
        }

        private async void btnCarros_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Carros());
        }
    }
}