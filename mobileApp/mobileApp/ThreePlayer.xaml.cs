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
	public partial class ThreePlayer : ContentPage
	{
        public static string player1; //saves the name for player 1
        public static string player2; //saves the name for player 2
        public static string player3; //saves the name for player 3

        public ThreePlayer ()
		{
			InitializeComponent ();
            image1();
            image2();
            image3();
        }

        private void image1()
        {
            var assembly = typeof(twoPlayer);
            string filename = "mobileApp.Images.1playerImage.png";
            imageMain1.Source = ImageSource.FromResource(filename, assembly);
        }

        private void image2()
        {
            var assembly = typeof(twoPlayer);
            string filename2 = "mobileApp.Images.1playerImage.png";
            imageMain2.Source = ImageSource.FromResource(filename2, assembly);
        }
        private void image3()
        {
            var assembly = typeof(twoPlayer);
            string filename3 = "mobileApp.Images.1playerImage.png";
            imageMain3.Source = ImageSource.FromResource(filename3, assembly);
        }
        //BELOW SENDING PAGE (THREEPLAYER) TO GAME PAGE USING BUTTON
        private void buttonClickThis_Clicked(object sender, EventArgs e)
        {
            player1 = "player 1:"+NameEntry.Text; //sends player 1 name to page gamepage
            player2 = "player 2:"+NameEntry2.Text; //sends player 2 name to page gamepage
            player3 = "player 3:"+NameEntry3.Text; //sends player 3 name to page gamepage

            Navigation.PushAsync(new gamePage());
        }
    }
}