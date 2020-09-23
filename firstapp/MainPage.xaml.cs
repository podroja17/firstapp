using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace firstapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if(Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
            
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Important alert", "Bonk!", "oof");    
        }
    }
}
