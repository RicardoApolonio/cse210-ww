using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Soccer Skills";
        video1._author = "Ricardo";
        video1._length = 10;

        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "Great video!";

        Comment comment2 = new Comment();
        comment2._name = "Maria";
        comment2._text = "Very helpful.";

        Comment comment3 = new Comment();
        comment3._name = "Alex";
        comment3._text = "Awesome skills!";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Cooking Pasta";
        video2._author = "Sofia";
        video2._length = 15;

        Comment comment4 = new Comment();
        comment4._name = "Mike";
        comment4._text = "Looks delicious!";

        Comment comment5 = new Comment();
        comment5._name = "Emma";
        comment5._text = "I will try this recipe.";

        Comment comment6 = new Comment();
        comment6._name = "Chris";
        comment6._text = "Nice tutorial.";

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Gaming Highlights";
        video3._author = "Lucas";
        video3._length = 20;

        Comment comment7 = new Comment();
        comment7._name = "Daniel";
        comment7._text = "Amazing gameplay!";

        Comment comment8 = new Comment();
        comment8._name = "Sarah";
        comment8._text = "So entertaining.";

        Comment comment9 = new Comment();
        comment9._name = "Kevin";
        comment9._text = "Best video today.";

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} minutes");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment.GetCommentDetails());
            }

            Console.WriteLine();
        }
    }
}