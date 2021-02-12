using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using ExerciseApp.Model;

using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using ExerciseApp.ViewModel;


namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPostPage : ContentPage
    {
        NewTravelVM viewModel;
        //Post post;
        public NewPostPage()
        {
            InitializeComponent();

            viewModel = new NewTravelVM();
            BindingContext = viewModel;

            //post = new Post();
            //containerStackLayout.BindingContext = post;
        }
        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }

        /* private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                {
                    //Experience = experienceEntry.Text,
                    post.UserId = App.user.Id;
                    
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

               /* Post.Insert(post);
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
        }*/
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Location);
            }
            catch (Exception ex)
            {

            }
        }
    }
}