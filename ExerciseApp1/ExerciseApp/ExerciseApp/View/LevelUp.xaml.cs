﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LevelUp : ContentPage
    {
        public LevelUp()
        {
            InitializeComponent();
        }
        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralFitnessSkillTree());
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralFitnessSkillTree());
        }
    }
}