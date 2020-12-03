using ExerciseApp.View;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using ExerciseApp.Model;

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

            var assembly = typeof(MainPage);
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
                var user = (await App.MobileService.GetTable<User>().Where(u => u.Email == usernameEntry.Text).ToListAsync()).FirstOrDefault();

                if (App.OnboardingComplete && user != null)
                {
                    App.user = user;
                    if (user.Password == passwordEntry.Text)
                        await Navigation.PushAsync(new HomePage());
                    else
                        await DisplayAlert("Error", "Email or password are incorrect", "Ok");

                }
                else if (user != null)
                {
                    if (user.Password == passwordEntry.Text)
                        await Navigation.PushAsync(new Onboarding1());
                }
                else 
                {
                    await DisplayAlert("Error", "Email or password are incorrect", "Ok");
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
