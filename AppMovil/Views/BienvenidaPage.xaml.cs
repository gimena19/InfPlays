using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage()
        {
            InitializeComponent();
        }

        async void BtnIrlogin_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new LoginPage());
        }

        async void BtnIrRegistrer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrer());
        }
    }
}