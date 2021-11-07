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
    public partial class Motos : ContentPage
    {
        public Motos()
        {
            InitializeComponent();
        }

        private async void Harley_Davidson_Livewire_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Harley Davidson Livewire", "Es la nueva Motocicleta por parte " +
                "de Harley Davidson y es completamente electrica.", "Salir");
        }

        private async void KTM_Duke_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("KTM DUKE 390", "Este proyectil en curvas maximiza el placer de" +
                " pilotaje con la relación calidad precio, llevándose todos los elogios cuando lo que cuenta es la agilidad. ", "salir");
        }

        private async void Kawasaki_H2R_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kawasaki Ninja H2R", "La única motocicleta hiperdeportiva sobrealimentada " +
                "de producción limitada del mundo representa la cúspide de la ingeniería de Kawasaki.", "salir");
        }

        private async void Ducati_Panigale_V4R_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ducati Panigale V4R", "La nueva Panigale V4 R es una moto de categoría WSBK " +
                "homologada para el uso en carretera y es el punto de partida del que se derivan los modelos oficiales de Ducati Superbike.", "salir");
        }

        private async void Ducati_Streetfigther_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ducati Streetfigther", "Para 2021 Ducati presenta la Streetfighter V4 S en un nuevo color Dark Stealth, " +
                "el cual se une al deportivo Ducati Red, 1100 cc con 208 hp, alas biplano, y un paquete electrónico completo. ", "salir");
        }

        private async void Yamaha_YZF_H1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Yamaha YZF H1", "Un diseño innovador super deportivo nunca antes visto, un nuevo motor con diseño de " +
                "cigüeñal crossplane, una distancia reducida entre ejes y unos sofisticados controles electrónicos.", "salir");
        }
    }
}