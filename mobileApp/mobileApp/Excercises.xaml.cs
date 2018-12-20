using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Excercises : ContentPage
	{
		public Excercises ()
		{
			InitializeComponent ();
            image1();
            image2();
            image3();
            image4();
            image5();
            image6();
            image7();
            image8();
        }
        private void image1()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.pushups.jpg";
            pushup1.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image2()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.jumpingjacks.jpg";
            jumpingjack2.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image3()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.crunches.jpg";
            crunches3.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image4()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.situps.jpg";
            situps4.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image5()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.lunges.jpg";
            lunges5.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image6()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.HighKnees.jpg";
            highknees6.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image7()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.sideplank.jpg";
            sideplank7.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image8()
        {
            var assembly = typeof(Excercises);
            string filename = "mobileApp.Images.squats.jpg";
            squats8.Source = ImageSource.FromResource(filename, assembly);
        }

        private void Button_home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}