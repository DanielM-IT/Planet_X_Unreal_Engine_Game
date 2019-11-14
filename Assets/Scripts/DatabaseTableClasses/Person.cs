using SQLite4Unity3d;

public class Person 
{
    [PrimaryKey]
    public string PlayerName { get; set; }
    public string PlayerPassword { get; set; }
    public int PlayerXP { get; set; }
}
