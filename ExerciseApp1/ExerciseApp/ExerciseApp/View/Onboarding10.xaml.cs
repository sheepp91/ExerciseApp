using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Onboarding10 : ContentPage
    {
        public Onboarding10()
        {
            InitializeComponent();
        }
        public async void OnImageButtonClicked(object sender, EventArgs e)
        {
            App.OnboardingComplete = true;
            App.SaveBool(App.OnboardingComplete, "OnboardingComplete");
            await Navigation.PushAsync(new SkillTreePage());
        }

        private async void Skip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}