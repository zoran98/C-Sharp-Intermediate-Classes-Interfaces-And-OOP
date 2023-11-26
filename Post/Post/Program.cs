using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Post1", "Something1", DateTime.Now);
            post1.Up_Vote();
            post1.Up_Vote();
            var first = post1.ShowVote();
            Console.WriteLine(first);

            Post post2 = new Post("Post2", "Something2", DateTime.Now);
            post2.Up_Vote();
            post2.Up_Vote();
            post2.Down_Vote();
            var second = post2.ShowVote();
            Console.WriteLine(second);

            Post post3 = new Post("Post3", "Something3", DateTime.Now);
            post3.Down_Vote();
            var third = post3.ShowVote();
            Console.WriteLine(third);

        }
    }
}
