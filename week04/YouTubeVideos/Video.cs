using System;

namespace YouTubeVideos
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        private List<Comment> _comments;

        public Video (string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} min");
        }

        public void DisplayComments()
        {
            Console.WriteLine("Comments-");
            foreach (var comment in _comments)
            {
                comment.DisplayComment();
            }
        }
    }
}