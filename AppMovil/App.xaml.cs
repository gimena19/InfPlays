using AppMovil.Data;
using AppMovil.Models;
using AppMovil.Views;
using AppMovil.Views.InterfazUsuario;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppMovil
{
    public partial class App : Application
    {
        static DataBaseQuery database;

        public static DataBaseQuery Database
        {
            get
            {
                if(database == null)
                {
                    database = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "plays.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BienvenidaPage());
        }

        protected override void OnStart()
        {


            //User user = new User();
            //user.Email= "ingridpinilla9@gmail.com";
            //user.Password = "12345";
            //user.FullName = "ingrid jimena pinilla calderon";
            //user.Age = "19";

            //var result = App.Database.SaveUserAsync(user);

            List<User> Listusers = new List<User>();

            Listusers = App.Database.GetUsers().Result;


        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
