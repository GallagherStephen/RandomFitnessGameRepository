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
	public partial class twoPlayer : ContentPage
	{

        public static string player1; //saves the name for player 1
        public static string player2; //saves the name for player 2
		public twoPlayer ()
		{
			InitializeComponent ();
		}

        //BELOW SENDING PAGE (TWOPLAYER) TO GAME PAGE USING BUTTON
        private void buttonClickThis_Clicked(object sender, EventArgs e)
        {
            player1 ="player 1:"+ NameEntry.Text; //sends player 1 name to page gamepage
            player2 ="player 2:" + NameEntry2.Text; //sends player 2 name to page gamepage
            Navigation.PushAsync(new gamePage());    
        }
    }
}