using SQLite4Unity3d;

public class Dialogue
{ 
    [PrimaryKey, AutoIncrement]
    public int DialogId { get; set; }
    [NotNull]
    public string DialogName { get; set; }
    public string Dialog { get; set; }
}
