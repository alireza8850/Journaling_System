
namespace App;

public class Journal
{
    public int ID;
    public string Title;
    public string Content;
    public DateTime Date;
    public string Result;
    public List<string> Tags;


    public Journal(int id, string title, string content, DateTime date, string result, List<string> tags)
    {
        ID = id;
        Title = title;
        Content = content;
        Date = date;
        Result = result;
        Tags = tags;
    }

    public override string ToString()
    {
        return ID + "," + Title + "," + Content + "," + Date + "," + Result + "," + Tags;
    }


}