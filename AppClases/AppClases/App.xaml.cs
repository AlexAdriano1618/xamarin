using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppClases.Views;

using Xamarin.Forms;

namespace AppClases
{
	public partial class App : Application
	{
        #region Contructor
        public App()
        {
            InitializeComponent();
            //MainPage = new AppClases.MainPage();
            MainPage = new NavigationPage( new Login());
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
