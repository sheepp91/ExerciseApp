using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseApp.Model
{
    class User
    {
        public int m_id { get; set; }
        public string m_username { get; set; }
        public string m_password { get; set; }

        public User() {}
        public User(string username, string password)
        {
            this.m_username = username;
            this.m_password = password;
        }
    }
}
