class Comment
{
    public string _name;
    public string _text;

    public string GetCommentDetails()
    {
        return $"{_name}: {_text}";
    }
}