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
	public partial class SkillTreePage : ContentPage
	{
		public SkillTreePage()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent();
		}
		private async void Fitness(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new GeneralFitnessSurvey1());
		}
		private async void Running(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RunningDistanceSelect());
		}
		private async void Weight(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RunningDistanceSelect());
		}
		private async void Cycling(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RunningDistanceSelect());
		}
	}
}