using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "Egy poszt cime";
            post.Description = "Egy poszt leirasa...";
            post.Date = new DateTime(2019, 3, 25);
            post.upVote();
            post.upVote();
            post.upVote();
            post.downVote();
            post.upVote();
            post.upVote();
            post.downVote();
            post.downVote();
            post.upVote();
            post.upVote();
            post.downVote();
            Console.WriteLine("Cim: " + post.Title + " / Leiras: " + post.Description + " / Datum: " + post.Date + " / Szavazatok: " + post.Votes);
        }
    }
}
