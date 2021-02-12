using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Azure.Storage.Blobs;
using Microsoft.WindowsAzure.Storage;
using System.IO;

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

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Error", "This is not supported on your device", "Ok");
                    return;
                }

                var mediaOptions = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Medium
                };
                var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

                if (selectedImageFile == null)
                {
                    await DisplayAlert("Error", "There was an error when trying to get your image, please try again", "Ok");
                    return;
                }

                selectedImage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());

                UploadImage(selectedImageFile.GetStream());
        }

        private async void UploadImage(Stream stream)
        {
            var account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=exerciseapp1;AccountKey=YtS9S6hpyTS4w1GCm/iNf9pPrY6IuMmzhSeEC2wdngx7Qtk/qIhBeEgbyNPqdqmFZ3EHlqPl1Aip1HeFyunUcQ==;EndpointSuffix=core.windows.net");
            var client = account.CreateCloudBlobClient();
            var container = client.GetContainerReference("imagecontainer");
            await container.CreateIfNotExistsAsync();

            var name = Guid.NewGuid().ToString();
            var blockBlob = container.GetBlockBlobReference($"{name}.jpg");
            await blockBlob.UploadFromStreamAsync(stream);

            string url = blockBlob.Uri.OriginalString;
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