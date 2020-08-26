using System.Collections.Generic;
using Xamarin.Forms;

namespace ExerciseApp.View
{
    public partial class RunningDistanceSelect : ContentPage
    {
        public IList<DistanceSelect> Monkeys { get; private set; }

        public RunningDistanceSelect()
        {
            InitializeComponent();

            Monkeys = new List<DistanceSelect>();
            Monkeys.Add(new DistanceSelect
            {
                Name = "100m",
                Level= "1",
 
            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "200m",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "400m",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "800m",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "1500m",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "5km",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "10km",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "21km",

            });

            Monkeys.Add(new DistanceSelect
            {
                Name = "42km",

            });


            BindingContext = this;
        }
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            DistanceSelect tappedItem = e.Item as DistanceSelect;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DistanceSelect selectedItem = e.SelectedItem as DistanceSelect;
        }

        async void OnButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RunningSurvey());
        }
    }
}