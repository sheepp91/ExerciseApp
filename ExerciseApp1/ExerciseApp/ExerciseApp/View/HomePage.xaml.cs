
/*using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }
}
*/
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciseApp.ViewModel;

namespace ExerciseApp.View 
{ 

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        HomeVM viewModel;
        public HomePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            viewModel = new HomeVM();
            BindingContext = viewModel;
        }
    }
}