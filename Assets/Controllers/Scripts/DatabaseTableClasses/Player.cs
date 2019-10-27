using SQLite4Unity3d;

public class Player
{ 
    [PrimaryKey, AutoIncrement]
    public int PlayerId { get; set; }
    public string PlayerName { get; set; }
    public string PlayerPassword { get; set; }
    public int CurrentDialogue { get; set; }
    public int PlayerXP { get; set; }

}
