namespace ExerciseApp.Model
{
    class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string username, string password)
        {
            this.Email = username;
            this.Password = password;
        }
    }
}
