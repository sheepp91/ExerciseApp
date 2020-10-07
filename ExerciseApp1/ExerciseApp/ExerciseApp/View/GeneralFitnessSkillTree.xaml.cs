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
    public partial class GeneralFitnessSkillTree : ContentPage
    {
        public GeneralFitnessSkillTree()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralFitnessSurvey2());
        }

        public void TrackSkill(Object sender, EventArgs e)
        {
            Image image = sender as Image;
            string source = image.Source as FileImageSource;  //Getting the name of source as string
            if (String.Equals(source, "TrackSkill.png"))
            {
                image.Source = "TrackedSkill.png";
            }
            else
            {
                image.Source = "TrackSkill.png";
            }
        }
    }
}