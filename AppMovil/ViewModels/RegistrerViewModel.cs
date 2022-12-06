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
    public class RegistrerViewModel : BaseViewModel
    {
        #region Atrributes
        private string email;
        private string password;
        private string fullname;
        private string age;
        #endregion

        #region Properties
        public String EmailTxt
        {
            get { return email; }
            set { SetValue(ref this.email,value); }
        }

        public String PasswordTxt
        {
            get { return password; }
            set { SetValue(ref this.password, value); }
        }
        public String FullnameTxt
        {
            get { return fullname; }
            set { SetValue(ref this.fullname, value); }
        }

        public String AgeTxt
        {
            get { return age; }
            set { SetValue(ref this.age, value); }
        }
        #endregion

        #region Commands
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
            
        }
        #endregion

        #region Methods
        private async void RegisterMethod()
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

            if (string.IsNullOrEmpty(this.FullnameTxt))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                   "Error",
                   "You must enter a Fullname",
                   "accept"
                    );
                return;
            }

            if (string.IsNullOrEmpty(this.AgeTxt))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                   "Error",
                   "You must enter an Age",
                   "accept"
                    );
                return;
            }

            var user = new User
            {
                Email = EmailTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
                FullName = FullnameTxt.ToLower(),
                Age = AgeTxt.ToLower(),
                Creation_Date = DateTime.UtcNow.Date
            };
            await App.Database.SaveUserAsync(user);
            await Application.Current.MainPage.DisplayAlert("Registro", "Exitoso", "Volver");
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
        #endregion

        #region Constructor

        #endregion

    }
}
 









