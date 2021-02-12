﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ExerciseApp.Model
{
    public class User : INotifyPropertyChanged
    {
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public static async Task<bool> Login(string email, string password)
        {

            bool IsUsernameEmpty = string.IsNullOrEmpty(email);
            bool IsPasswordEmpty = string.IsNullOrEmpty(password);

            if (IsUsernameEmpty || IsPasswordEmpty) 
            {
                return false;
            }

            else
            {

                    var user = (await App.MobileService.GetTable<User>().Where(u => u.Email == email).ToListAsync()).FirstOrDefault();

                    if (App.OnboardingComplete && user != null)
                    {
                        App.user = user;
                        if (user.Password == password)
                            return true;
                        else
                            return false;
                    }
                    else if (user != null)
                    {
                        App.user = user;
                        if (user.Password == password)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }

            }

        }

        public static async void Register (User user)
        {
            await App.MobileService.GetTable<User>().InsertAsync(user);

        }

        //public User() { }
        //public User(string username, string password)
        //{
        //  this.Email = username;
        //this.Password = password;
        //}
    }
}
