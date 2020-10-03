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
    public partial class GeneralFitnessSurvey1 : ContentPage
    {
        public GeneralFitnessSurvey1()
        {
            InitializeComponent();
        }

        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralFitnessSurvey2());
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkillTreePage());
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            displayLabel.Text = String.Format("{0:0}", value);
        }

    }
}