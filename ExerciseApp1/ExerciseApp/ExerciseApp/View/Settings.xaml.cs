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
        private bool _isLiked;
        public bool IsLiked
        {
            get { return _isLiked; }
            set
            {
                _isLiked = value;
                OnPropertyChanged("IsLiked");
            }
        }

    }
}