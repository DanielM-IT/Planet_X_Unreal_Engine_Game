using SQLite4Unity3d;

public class Player 
{
    [PrimaryKey]
    public string PlayerName { get; set; }
    public string PlayerPassword { get; set; }
    public string CurrentStorySection { get; set; }
    public int PlayerXP { get; set; }
}
