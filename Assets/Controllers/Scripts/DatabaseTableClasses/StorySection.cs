using SQLite4Unity3d;

public class StorySection
{
    [PrimaryKey]
    public string SectionName { get; set; }
    public string FirstDialogueName { get; set; }
    public string PlayerUsername { get; set; }
}
