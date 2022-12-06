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
    public class LoginViewModel : BaseViewModel
    {
        #region Atrributes
        public string email;
        public string password;

        #endregion

        #region Properties
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);

            }
            set
            {

            }
        }



        #endregion

        #region Methods
        public async void Login()
        {
            if (string.IsNullOrEmpty(this.EmailTxt))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                   "Error",
                   "You must enter an email",
                   "accept"
                    );
                return;
            }

            if (string.IsNullOrEmpty(this.PasswordTxt))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                   "Error",
                   "You must enter a Password",
                   "accept"
                    );
                return;
            }




            string _query = "SELECT * FROM User WHERE Email = '" + EmailTxt.ToString() + "' AND PASSWORD = '" + PasswordTxt.ToString() + "'";
            List<User> users = App.Database.QueryUsers(_query).Result;

            if(users.Count>0)
            {
                
                await Application.Current.MainPage.Navigation.PushAsync(new MainMenuPage());

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
            }
        }
        #endregion

        #region Constructor


        #endregion
    }
}
