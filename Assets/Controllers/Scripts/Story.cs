using SQLite4Unity3d;

public class Story 
{
    [PrimaryKey]
    public string StoryName { get; set; }
    public string StoryDescription { get; set; }
    public int FirstDialogueID { get; set; }
}
