class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public string GetVideo()
    {
        return $"{_title} by {_author}. \n Length: {_length} seconds";
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}