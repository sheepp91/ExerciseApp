using ExerciseApp.View;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using ExerciseApp.Model;
using SQLite;
using Microsoft.WindowsAzure.MobileServices;
using ExerciseApp.ViewModel;

namespace ExerciseApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainVM viewModel;
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            viewModel = new MainVM();
            BindingContext = viewModel;
        }

        public async void NavigateButton_OnClicked(object sender, EventArgs e)
        {

            bool canLogin = await User.Login(emailEntry.Text, passwordEntry.Text);

            if (canLogin)
                await Navigation.PushAsync(new HomePage());

            else if (canLogin && App.OnboardingComplete)
                await Navigation.PushAsync(new HomePage());
            

            else
                await DisplayAlert("Error", "Try again", "Ok");

           /* bool IsUsernameEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if(IsUsernameEmpty || IsPasswordEmpty )
            {
                
            }
            
            else
            {
                var user = (await App.MobileService.GetTable<Users>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();

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
                    App.user = user;
                    if (user.Password == passwordEntry.Text)
                        await Navigation.PushAsync(new HomePage());
                }
                else 
                {
                    await DisplayAlert("Error", "Email or password are incorrect", "Ok");
                }
            } */

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
