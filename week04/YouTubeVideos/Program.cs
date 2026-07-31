using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments = new List<Comment>
        {
            new Comment(
                "Nyler",
                "Peter Parker 1 struggles to balance the best summer vacation ever and his responsibilities as Spider-Man."
            ),
            new Comment(
                "Lerny",
                "Peter Parker 2 struggles to balance the best summer vacation ever and his responsibilities as Spider-Man."
            ),
            new Comment(
                "Erlyn",
                "Peter Parker 3 struggles to balance the best summer vacation ever and his responsibilities as Spider-Man."
            ),
        };
        Video video1 = new Video(
            "How I Thwipped My Summer Vacation | Marvel's Spider-Man S2 E1 | Full Episode",
            "Marvel HQ",
            1320,
            comments
        );
        Video video2 = new Video(
            "Take Two | Marvel's Spider-Man S2 E2 | Full Episode",
            "Marvel HQ",
            1320,
            comments
        );
        Video video3 = new Video(
            "Between an Ock and a Hard Place | Marvel's Spider-Man S2 E3 | Full Episode",
            "Marvel HQ",
            1320,
            comments
        );

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Video length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine($"******** Comments ********");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"User: {comment.GetName()}");
                Console.WriteLine($"Commentf: {comment.GetText()}");
            }
        }
    }
}