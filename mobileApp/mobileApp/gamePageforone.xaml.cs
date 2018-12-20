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
	public partial class gamePageforone : ContentPage
	{
		public gamePageforone ()
		{
			InitializeComponent ();
            image1();
            image2();
            player1Name.Text = oneplayer.player1; //links the player one name to the label text on oneplayer page
        }
        private void image1()  //function to add image
        {
            var assembly = typeof(gamePage);
            string filename = "mobileApp.Images.1playerImage.png";             //saving image as a string variable
            imageMain.Source = ImageSource.FromResource(filename, assembly);
        }
        private void image2() //function to add image
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
            task.Text = "?";
        }
        private void button_task_Clicked(object sender, EventArgs e)
        {
            //generate random task from list below

            string[] strLabel =
            {

                "Do 5 sit ups",
                "Do 10 jumping jacks",
                "do 3 sit ups",
                "Do 5 push ups",
                "Do 17 squats",
                "Do 6 high knees",
                "Do 7 high Knees",
                "Do side plank for 20 seconds",
                "Do 15 sit ups",
                "Do side plank for 40 seconds",
                "Do 10 crunches",
                "Do 3 squats",
                "Do side plank for 120 seconds",
                "Do 2 sit ups",
                "Do 14 high knees",
                "Do 6 high knees",
                "Do 2 high Knees",
                "Do side plank for 20 seconds",
                "Do 11 sit ups",
                "Do side plank for 40 seconds",
                "Do 8 crunches",
                "Do 8 squats",
                "Do 8 lunges",
                "Do side plank for 60 seconds",
                "Do 2 crunches",
                "Do 3 squats",
                "Do 4 lunges",
                "Do 16 high knees",
                "Do 20 high Knees",
                "Do side plank for 200 seconds",

            };
            Random r = new Random();
            int iSelect = r.Next(0, 30);
            task.Text = strLabel[iSelect];
        }
        
        private void Button_home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage()); //sends user to main page
        }
    }
}