using Xamarin.Forms;
using Android.Content;
using Android.Preferences;

namespace ExerciseApp
{
    public partial class App : Application
    {
        public static bool OnboardingComplete = false;
        static ISharedPreferences savedVars;
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental", "RadioButton_Experimental" });
            MainPage = new NavigationPage(new MainPage());

        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
            Context mContext = Android.App.Application.Context;
            savedVars = PreferenceManager.GetDefaultSharedPreferences(mContext);
            OnboardingComplete = GetSavedBool("OnboardingComplete");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


        //Save booleans
        public static void SaveBool(bool boolToSave, string name)
        {
            ISharedPreferencesEditor editor = savedVars.Edit();
            editor.PutBoolean(name, boolToSave);
        }

        public static bool GetSavedBool(string name)
        {
            return savedVars.GetBoolean(name, false);
        }

        //Save strings
        public static void SaveString(string stringToSave, string name)
        {
            ISharedPreferencesEditor editor = savedVars.Edit();
            editor.PutString("name", stringToSave);
        }

        public static string GetSavedString(string name)
        {
            return savedVars.GetString(name, "");
        }

        //Save ints
        public static void SaveInt(int intToSave, string name)
        {
            ISharedPreferencesEditor editor = savedVars.Edit();
            editor.PutInt(name, intToSave);
        }

        public static int GetSavedInt(string name)
        {
            return savedVars.GetInt(name, -1);
        }

        //Save float
        public static void SaveFloat(float floatToSave, string name)
        {
            ISharedPreferencesEditor editor = savedVars.Edit();
            editor.PutFloat(name, floatToSave);
        }

        public static float GetSavedFloat(string name)
        {
            return savedVars.GetFloat(name, -1.0f);
        }
    }
}
