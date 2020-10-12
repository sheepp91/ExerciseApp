using ExerciseApp.View;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExerciseApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Onboarding1());
        }
        private async void RegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        private async void Skip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
