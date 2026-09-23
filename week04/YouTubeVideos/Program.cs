using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Introduction to Solar Energy",
            "Sunday Okpara",
            600);

        video1.AddComment(new Comment(
            "John",
            "This is a very informative video."));

        video1.AddComment(new Comment(
            "Mary",
            "I learned a lot about solar energy."));

        video1.AddComment(new Comment(
            "David",
            "Great explanation!"));

        video1.AddComment(new Comment(
            "Grace",
            "I enjoyed watching this video."));

        Video video2 = new Video(
            "Learning C# Programming",
            "Sunday Okpara",
            900);

        video2.AddComment(new Comment(
            "Peter",
            "C# is becoming easier to understand."));

        video2.AddComment(new Comment(
            "Sarah",
            "Thank you for this tutorial."));

        video2.AddComment(new Comment(
            "James",
            "Very helpful lesson."));

        video2.AddComment(new Comment(
            "Michael",
            "I learned something new today."));

        Video video3 = new Video(
            "Electrical Installation Basics",
            "Sunday Okpara",
            750);

        video3.AddComment(new Comment(
            "Daniel",
            "This helped me understand electrical installation."));

        video3.AddComment(new Comment(
            "Rebecca",
            "Excellent explanation."));

        video3.AddComment(new Comment(
            "Samuel",
            "I would like to see more videos like this."));

        video3.AddComment(new Comment(
            "Esther",
            "Very useful information."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}