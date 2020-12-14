using ExerciseApp.Model;
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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void registerButton_Clicked(object sender, EventArgs e)
        {
            if (passwordEntry.Text == confirmPasswordEntry.Text)
            {
                // We can register the user
                Users user = new Users()
                {
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text
                };

                await App.MobileService.GetTable<Users>().InsertAsync(user);
                await DisplayAlert("Success", "New user created", "Ok");


            }
            else
            {
                await DisplayAlert("Error", "Passwords don't match", "Ok");
            }
        }
    }
}