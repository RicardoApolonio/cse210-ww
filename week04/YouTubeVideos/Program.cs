using System;
using System.Collections.Generic;

List<Video> videos = new List<Video>();

Video video1 = new Video("Learning C#", "Code Academy", 420);
video1.AddComment(new Comment("John", "This video was very helpful."));
video1.AddComment(new Comment("Maria", "I learned a lot from this video."));
video1.AddComment(new Comment("Peter", "Great explanation!"));
videos.Add(video1);

Video video2 = new Video("How to Make Pizza", "Cooking Home", 600);
video2.AddComment(new Comment("Anna", "The pizza looks delicious."));
video2.AddComment(new Comment("David", "I will try this recipe."));
video2.AddComment(new Comment("Sarah", "Very easy to follow."));
videos.Add(video2);

Video video3 = new Video("Best Exercises at Home", "Fitness Life", 480);
video3.AddComment(new Comment("Michael", "Great workout!"));
video3.AddComment(new Comment("Emily", "This was perfect for me."));
video3.AddComment(new Comment("James", "I will do this every morning."));
videos.Add(video3);

foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video._title}");
    Console.WriteLine($"Author: {video._author}");
    Console.WriteLine($"Length: {video._length} seconds");
    Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
    Console.WriteLine("Comments:");

    foreach (Comment comment in video._comments)
    {
        Console.WriteLine($"- {comment._name}: {comment._text}");
    }

    Console.WriteLine();
}