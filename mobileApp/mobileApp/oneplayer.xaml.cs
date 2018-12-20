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
	public partial class oneplayer : ContentPage
	{
        public static string player1; //saves the name for player 1
        public oneplayer ()
		{
			InitializeComponent ();
            image1();
		}
        private void image1()
        {
            var assembly = typeof(twoPlayer);
            string filename2 = "mobileApp.Images.1playerImage.png";
            imageMain.Source = ImageSource.FromResource(filename2, assembly);
        }


        //BELOW SENDING PAGE (oneplayer) TO GAME PAGEfor 1 USING BUTTON
        private void buttonClickThis_Clicked(object sender, EventArgs e)
        {
            player1 = "player 1:" + NameEntry.Text; //sends player 1 name to page gamepage
            Navigation.PushAsync(new gamePageforone());
        }

        
    }
}