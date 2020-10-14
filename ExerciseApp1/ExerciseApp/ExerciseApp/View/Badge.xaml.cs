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
    public partial class Badge : ContentPage
    {
        public Badge()
        {
            InitializeComponent();
            level.Text = "Level 5";
        }
        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RunningSkillTree());
        }
        private async void Share(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Share your Result?", "", "Yes", "No");
            Console.WriteLine("Answer: " + answer);
        }
    }  
}