using System;

namespace StackOvermimic
{
    class Program
    {
        static void Main(string[] args)
        {
            var postTitle = "This is my new program!";
            var postDescription = "It is supposed to mimic the class of a post on Stack Overflow!";

            var UserPost = new Post(postTitle, postDescription);

            Console.WriteLine(UserPost.Votes);

            for (int i = 0; i <= 10; i++)
            {
                UserPost.UpVote();
            }
            for (int n = 0; n < 4; n++)
            {
                UserPost.DownVote();
            }

            Console.WriteLine(UserPost.Votes);

        }
    }
}
