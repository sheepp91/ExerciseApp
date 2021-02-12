using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseApp.ViewModel.Commands;
using ExerciseApp.View;

namespace ExerciseApp.ViewModel
{
    public class HomeVM
    {
        public NavigationCommand NavCommand { get; set; }

        public HomeVM()
        {
            NavCommand = new NavigationCommand(this);
        }

        public async void Navigate()
        {
            //TODO
            await App.Current.MainPage.Navigation.PushAsync(new NewPostPage());
        }
    }
}
