using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFOnAppTheme
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new List<string> {
                "AppTheme_Experimental"
            });

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
