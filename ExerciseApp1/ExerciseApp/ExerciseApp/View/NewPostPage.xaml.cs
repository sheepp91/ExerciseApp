using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using ExerciseApp.Model;


namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPostPage : ContentPage
    {
        public NewPostPage()
        {
            InitializeComponent();
        }
        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Post post = new Post()
                {
                    Experience = experienceEntry.Text,
                    UserId = App.user.Id
                    
                };

                /*using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    int rows = conn.Insert(post);

                    if (rows > 0)
                        DisplayAlert("Success", "Experience succesfully inserted", "Ok");
                    else
                        DisplayAlert("Failure", "Experience failed to be inserted", "Ok");
                }*/

                Post.Insert(post);
                //await App.MobileService.GetTable<Post>().InsertAsync(post);
                await DisplayAlert("Success", "Experience succesfully inserted", "Ok");

            }
            catch (NullReferenceException nre)
            {
                await DisplayAlert("Failure", "Experience failed to be inserted", "Ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Failure", "Experience failed to be inserted", "Ok");

            }
        }
    }
}