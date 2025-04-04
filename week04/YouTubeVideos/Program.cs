using System;

namespace YouTubeVideos
{

    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Video 1", "The Great Channel", 5);
            video1.DisplayInformation();
            video1.AddComment(new Comment("Josh", "'Great Video, I learned a lot!'"));
            video1.AddComment(new Comment("Casper", "'Amazing video!'"));
            video1.AddComment(new Comment("Ron", "'superb! video!'"));
            video1.DisplayComments();
            Console.WriteLine();

            Video video2 = new Video("Video 2", "Mark", 13);
            video2.DisplayInformation();
            video2.AddComment(new Comment("Mathew", "'Wow, what an amzing video!'"));
            video2.AddComment(new Comment("James", "'Amazing video!'"));
            video2.AddComment(new Comment("Rebecca", "'Thanks for the video!'"));
            video2.DisplayComments();
            Console.WriteLine();

            Video video3 = new Video("Video 3", "Patricia", 6);
            video3.DisplayInformation();
            video3.AddComment(new Comment("Hope", "'Amazing video!'"));
            video3.AddComment(new Comment("Max", "'Amazing video!'"));
            video3.AddComment(new Comment("Samantha", "'Amazing video!'"));
            video3.DisplayComments();
            Console.WriteLine();

            Video video4 = new Video("Video 4", "The colors channel", 10);
            video4.DisplayInformation();
            video4.AddComment(new Comment("Josh", "'Excellent channel I highly recommend'"));
            video4.AddComment(new Comment("Hallie", "'This channel deserves more likes!'"));
            video4.AddComment(new Comment("Joe", "'I would like to learn more!'"));
            video4.DisplayComments();

            List<Video> _videos = new List<Video> { video1, video2, video3, video4 };

            foreach (var video in _videos)
            {
                video.DisplayInformation();
                video.DisplayComments();
                Console.WriteLine();
                
 
           }
        }
    }
}