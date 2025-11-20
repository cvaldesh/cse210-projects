using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video v1 = new Video("Understanding Abstraction in C#", "Tech Explained", 480);
        v1.AddComment(new Comment("Alice", "This video made abstraction easy to understand!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Carlos", "I finally get it. Thanks!"));
        videos.Add(v1);

        // --- Video 2 ---
        Video v2 = new Video("How to Cook Pasta", "Chef Mario", 300);
        v2.AddComment(new Comment("Laura", "My pasta came out perfect!"));
        v2.AddComment(new Comment("John", "Very clear steps."));
        v2.AddComment(new Comment("Sofia", "Simple and helpful."));
        videos.Add(v2);

        // --- Video 3 ---
        Video v3 = new Video("Beginner Workout Routine", "FitLife", 600);
        v3.AddComment(new Comment("Mark", "I needed this routine!"));
        v3.AddComment(new Comment("Ana", "Short but effective."));
        v3.AddComment(new Comment("Diego", "Thanks, starting tomorrow."));
        videos.Add(v3);

        // --- Print all videos ---
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
