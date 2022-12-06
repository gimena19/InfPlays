using AppMovil.Models;
using AppMovil.Views;
using AppMovil.Views.InterfazUsuario;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMovil.ViewModels
{
    public class MainMenuViewModel :BaseViewModel
    {
        #region Commands
        public ICommand NatacionCommand
        {
            get
            {
                return new RelayCommand(Natacion);

            }
        }

        public ICommand PesasCommand
        {
            get
            {
                return new RelayCommand(Pesas);

            }
        }

        public ICommand GimCommand
        {
            get
            {
                return new RelayCommand(Gimnasia);

            }
        }
        #endregion

        #region Methods
        public async void Natacion()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage());

        
        }

        public async void Pesas()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage());


        }

        public async void Gimnasia()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage());


        }

        #endregion

    }
}
