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
            addImagesToPage();

            player1Name.Text = twoPlayer.player1;
            player2Name.Text = twoPlayer.player2;
        }

        private void addImagesToPage()
        {
            var assembly = typeof(MainPage);
            string strFilename = "mobileApp.Images.red.png";
            pictureFilename.Source = ImageSource.FromResource(strFilename, assembly);
            string mainImage = "mobileApp.Images.ImageMain.png";
            
        }


        private void button_yes_Clicked(object sender, EventArgs e)
        {
            //SEND TO CONGRADULATIONS U COMPLETED YOUR TASK! 
            //Navigation.PushAsync(new completedTaskPage());
        }

        private void button_no_Clicked(object sender, EventArgs e)
        {
            //SEND TO YOU DIDNT COMPLETE TASK BETTER LUCK NEXT TIME!
            //Navigation.PushAsync(new didntCompleteTaskPage());
        }

        int image1;
        //string image1 = "mobileApp.Images.red.png"; //DO I ASSIGN AN IMAGE TO IMAGE1 TO START OFF?? WITH SWITCH BELOW??

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //select at random another image
            Random random = new Random();
            image1 = random.Next(1, 4); //number of images 
            string pictureFilename;
            var assembly = typeof(MainPage);

            switch (image1)
            {
                case 1:
                    pictureFilename  = "mobileapp.Images.Orange.jpg";

                    break;

                case 2:
                    pictureFilename = "mobileApp.Images.red.png";

                    break;

                case 3:
                    pictureFilename = "mobileApp.Images.pink.png";

                    break;

            }
            

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