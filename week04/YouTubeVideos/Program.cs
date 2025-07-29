using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("How abstraction works", "Alonso Alvarado", 300);
        Video video2 = new Video("Encapsulation made simple", "Maria Lopez", 250);
        Video video3 = new Video("Polymorphism explained", "Daniel Rivera", 400);
        Video video4 = new Video("Inheritance for beginners", "Laura Mendoza", 180);


        video1.AddComment(new Comment("Carlos", "I love this video, very clear."));
        video1.AddComment(new Comment("Ana", "The examples helped a lot."));
        video1.AddComment(new Comment("Luis", "Great explanation on abstraction."));

        video2.AddComment(new Comment("Sofia", "Encapsulation finally makes sense!"));
        video2.AddComment(new Comment("Jorge", "Short and sweet."));
        video2.AddComment(new Comment("Natalia", "Helpful for beginners!"));

        video3.AddComment(new Comment("Diego", "Polymorphism sounds scary but this helped."));
        video3.AddComment(new Comment("Emma", "Nice visuals and examples."));
        video3.AddComment(new Comment("Omar", "Could you do more videos like this?"));

        video4.AddComment(new Comment("Michael", "Loved the inheritance breakdown."));
        video4.AddComment(new Comment("Laura", "Very easy to follow."));
        video4.AddComment(new Comment("Esteban", "Helpful for my final project."));
      
        List<Video> videos = new List<Video> {video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------\n");

            Console.WriteLine("Video Info:");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetDuration() / 60:F1} minutes : {video.GetDuration()} seconds");
            Console.WriteLine($"Total comments: {video.GetCommentCount()}");

                    // Show the comments
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.ShowUserNameAndText());
            }
        }



    }
}