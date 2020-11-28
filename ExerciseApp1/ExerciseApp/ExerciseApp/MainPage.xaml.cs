using ExerciseApp.View;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using ExerciseApp.View;
using Android.Preferences;
using Android.Content;

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
        public async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            bool IsUsernameEmpty = string.IsNullOrEmpty(usernameEntry.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if(IsUsernameEmpty || IsPasswordEmpty )
            {
                
            }
            
            else
            {
                if (App.OnboardingComplete)
                {
                    await Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await Navigation.PushAsync(new Onboarding1());
                }
            }

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
