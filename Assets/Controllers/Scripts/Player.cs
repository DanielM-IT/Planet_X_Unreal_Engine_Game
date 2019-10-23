using SQLite4Unity3d;

public class Player 
{
    [PrimaryKey, AutoIncrement]
    public int AccountId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string CurrentScene { get; set; }
    public int XpPoints { get; set; }

}
