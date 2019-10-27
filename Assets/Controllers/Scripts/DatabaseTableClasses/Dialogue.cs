using SQLite4Unity3d;

public class Dialogue 
{
    [PrimaryKey, AutoIncrement]
    public int DialogueId { get; set; }
    [NotNull]
    public string DialogueName { get; set; }
    public string CurrentDialogue { get; set; }
    public string SectionName { get; set; }
}
