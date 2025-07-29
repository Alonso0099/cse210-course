public class Video
{
    private string _title;
    private string _author;
    private double _duration;
    private List<Comment> _comments = new List<Comment>();
    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public List<Comment> GetComments() => _comments;
    public double GetDuration() => _duration;
    public int GetCommentCount() => _comments.Count;
    
    
    //Show all the information of the video
    public Video(string title, string author, double duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }




//Retunr the count of the comments. 
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}