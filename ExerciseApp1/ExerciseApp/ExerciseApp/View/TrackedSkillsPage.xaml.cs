using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackedSkillsPage : ContentPage
    {
        public TrackedSkillsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            title.Text = "Friends Page";
        }
        private void Button_OnClicked(object sender, EventArgs e)
        {
            title.Text = "You have no friends";
        }
    }
}