using ComposicaoEStringBuilder.Entities;
using System;

namespace ComposicaoEStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("That's awesome!");

            Post p1 = new Post(
                DateTime.Parse("27/01/2022 19:20:02"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force with you");

            Post p2 = new Post(
                DateTime.Parse("24/05/2021 13:01:05"),
                "Hello and goodbye",
                "See you tomorrow",
                12
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
