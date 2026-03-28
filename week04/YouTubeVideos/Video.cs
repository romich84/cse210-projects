namespace YouTubeVideos;

public class Video
{
   private string _title;
   private string _author;
   private int _length;
   private List<Comment> _comments = new List<Comment>();
   
   public Video(string title, string author, int length)
   {
      _title = title;
      _author = author;
      _length = length;
   }

   public string GetTitle()
   {
      return _title;
   }

   public void SetTitle(string title)
   {
      _title = title;
   }

   public string GetAuthor()
   {
      return _author;
   }

   public void SetAuthor(string author)
   {
      _author = author;
   }

   public string GetLength()
   {
      return _length.ToString();
   }

   public void SetLength(int length)
   {
      _length = length;
   }
   public List<Comment> GetComments()
   {
      return _comments;
   }

   public void SetComments(List<Comment> comments)
   {
      _comments = comments;
   }

   public void AddComment(Comment comment)
   {
      _comments.Add(comment);
   }
   public int GetNumberOfComments()
   {
      return _comments.Count;
   }

   public void GetDisplayVideo()
   {
      Console.WriteLine($"Title: {GetTitle()}");
      Console.WriteLine($"Author: {GetAuthor()}");
      Console.WriteLine($"Length: {GetLength()}");
      Console.WriteLine($"Comments: {GetNumberOfComments()}");
      foreach (Comment comment in _comments)
      {
         comment.GetDisplayComment();
      }
      
   }
}