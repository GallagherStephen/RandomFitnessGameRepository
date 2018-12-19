using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mobileApp
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            //ROOT OF APPLICATION #MAINPAGE

            MainPage = new NavigationPage(new MainPage());
            //ADDING IMAGE???????
            ImageSource.FromResource("mobileApp.red.png");
          
        }

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
    }
}
