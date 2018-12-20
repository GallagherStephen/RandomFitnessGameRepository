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
	public partial class RulesAndInfo : ContentPage
	{
		public RulesAndInfo ()
		{
			InitializeComponent ();
		}
        private void Button_home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}