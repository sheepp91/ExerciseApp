using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciseApp.Model;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            stkTab1.IsVisible = true;
            stkTab2.IsVisible = false;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            /*using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();
                postListView.ItemsSource = posts;
            }
            }*/

            var posts = await App.MobileService.GetTable<Post>().Where(p => p.UserId == App.user.Id).ToListAsync();
            postListView.ItemsSource = posts;
        }
        private void Tab1Clicked(object sender, EventArgs e)
            {
                stkTab1.IsVisible = true;
                stkTab2.IsVisible = false;
            }

            private void Tab2Clicked(object sender, EventArgs e)
            {
                stkTab1.IsVisible = false;
                stkTab2.IsVisible = true;
            }

            private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new NewPostPage());
            }
        }
    }
