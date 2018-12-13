using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quetzal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageItem : ContentPage
	{
		public PageItem ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("titre", "message affiché", "OK");
        }
    }
}