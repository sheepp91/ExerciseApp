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
    public partial class Onboarding10 : ContentPage
    {
        public Onboarding10()
        {
            InitializeComponent();
        }
        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkillTreePage());
        }

        private async void Skip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkillTreePage());
        }
    }
}