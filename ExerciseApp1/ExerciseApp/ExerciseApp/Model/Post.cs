using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseApp.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }

        public string UserId { get; set; }

        public static async void Insert(Post post)
        {
            await App.MobileService.GetTable<Post>().InsertAsync(post);
        }
    }
}




