using AppMovil.Models;
using AppMovil.Views;
using AppMovil.Views.InterfazUsuario;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMovil.ViewModels.Interfazusuario
{
    internal class EntrenamientoViewModel :BaseViewModel

    {
        #region Commands
        public ICommand EspaldaCommand
        {
            get
            {
                return new RelayCommand(Espalda);

            }
        }

        public ICommand MariposaCommand
        {
            get
            {
                return new RelayCommand(Mariposa);

            }
        }

        public ICommand CrolCommand
        {
            get
            {
                return new RelayCommand(Crol);

            }
        }

        public ICommand BrazaCommand
        {
            get
            {
                return new RelayCommand(Braza);

            }
        }
        #endregion

        #region Methods
        public async void Espalda()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EspaldaPage());


        }

        public async void Mariposa()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MariposaPage());


        }

        public async void Crol()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CrolPage());


        }

        public async void Braza()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BrazaPage());


        }

        #endregion

    }
}
