﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ExerciseApp.Model;

namespace ExerciseApp.ViewModel.Commands
{
    public class PostCommand : ICommand
    {
        NewTravelVM viewModel;

        public event EventHandler CanExecuteChanged;

        public PostCommand(NewTravelVM viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            var post = (Post)parameter;

            if(post != null)
            {
                if (string.IsNullOrEmpty(post.Experience))
                    return false;

                return false;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            var post = (Post)parameter;
            viewModel.PublishPost(post);
        }
    }
}
