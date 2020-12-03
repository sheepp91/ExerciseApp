using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            stkTab1.IsVisible = true;
            stkTab2.IsVisible = false;

        }

        private void Tab1Clicked(object sender, EventArgs e)
        {
            stkTab1.IsVisible = true;
            stkTab2.IsVisible = false;
        }

        private void Tab2Clicked(object sender, EventArgs e)
        {
            stkTab1.IsVisible = false;
            stkTab2.IsVisible = true;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPostPage());
        }
    }
}