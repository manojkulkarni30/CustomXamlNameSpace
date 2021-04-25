using System;
using SharedLibrary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XmlnsDefAttributeDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MyLibrary.Init();
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
