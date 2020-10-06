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
    public partial class SurveyDOB : ContentPage
    {
        public SurveyDOB()
        {
            InitializeComponent();
        }
        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SurveyGender());
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Onboarding3());
        }


        private DateTime _DateSelected;

        public DateTime DateSelected
        {
            get { return _DateSelected; }
            set
            {
                if (_DateSelected.Equals(value))
                {
                    return;
                }

                _DateSelected = value;

                // check someone is too young or not
                var age = CalculateAge(_DateSelected);
            }
        }

        private int CalculateAge(DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }


    }
}