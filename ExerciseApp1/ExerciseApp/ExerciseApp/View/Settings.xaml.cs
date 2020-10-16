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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Feedback());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateRecord());

        }
        //private bool _isLiked;
        //public bool IsLiked
        //{
        //  get { return _isLiked; }
        //set
        //{
        //  _isLiked = value;
        // OnPropertyChanged("IsLiked");
        //}
        //}

    }
}