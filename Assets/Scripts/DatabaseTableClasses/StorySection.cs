using SQLite4Unity3d;

// Properties used to access the data in the StorySection SQLite table
public class StorySection
{ 
    [PrimaryKey]
    public string SectionName { get; set; }
    public string FirstDialogueName { get; set; }
}
