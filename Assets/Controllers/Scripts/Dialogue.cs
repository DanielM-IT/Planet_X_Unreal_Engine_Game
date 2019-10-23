using SQLite4Unity3d;

public class Dialogue 
{
    [PrimaryKey, AutoIncrement]
    public int DialogueId { get; set; }
    [NotNull]
    public string DialogueName { get; set; }
    public string DialogueDescription { get; set; }

}
