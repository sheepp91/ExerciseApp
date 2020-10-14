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
    public partial class RunningSurvey : ContentPage
    {
        public RunningSurvey()
        {
            InitializeComponent();
        }
        private async void Back(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RunningDistanceSelect());
        }
        async void OnImageButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RunningBadge());
        }
    }
}