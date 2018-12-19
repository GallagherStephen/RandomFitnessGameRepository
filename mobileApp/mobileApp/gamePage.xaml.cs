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
	public partial class gamePage : ContentPage
	{
		public gamePage ()
		{
			InitializeComponent ();
            image1();
            image2();
            player1Name.Text = twoPlayer.player1;
            player2Name.Text = twoPlayer.player2;
        }

        private void image1()
        {
            var assembly = typeof(gamePage);
            string filename = "mobileApp.Images.1playerImage.png";
            imageMain.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image2()
        {
            var assembly = typeof(gamePage);
            string filename = "mobileApp.Images.taskImage.png";
            imageMain1.Source = ImageSource.FromResource(filename, assembly);
        }
        private void button_yes_Clicked(object sender, EventArgs e)
        {
            //CHANGES THE LABEL yesORno TO THE TEXT BELOW:
            yesORno.Text = "Congradulations you completed your task";

        }

        private void button_no_Clicked(object sender, EventArgs e)
        {
            //CHANGES THE LABEL yesORno TO THE TEXT BELOW:
            yesORno.Text = "Sorry you did not complete task please try again";
            
        }

       private void Button_refresh_Clicked(object sender, EventArgs e)
        {   //CHANGES THE LABEL yesORno TO THE TEXT BELOW:
            yesORno.Text = "?";
        }
        private void button_task_Clicked(object sender, EventArgs e)
        {
            //generate random task from list below

            string[] strLabel =
            {

                "take a 1",
                "take a 2",
                "do 3",
                "take a 4",
                "take  5",
                "take a 6",
                "take  7",
                "do 8",
                "take a 9",
                "take a 10",

            };
            Random r = new Random();
            int iSelect = r.Next(0, 10);
            task.Text = strLabel[iSelect];
        }

        private void Button_next_Clicked(object sender, EventArgs e)
        {
            //generate random player from list below

            string[] strLabel =
            {

                "Player 1",
                "Player 2",

            };
            Random n = new Random();
            int iSelect = n.Next(0, 2);
            next.Text = strLabel[iSelect];
        }

        
    }
}