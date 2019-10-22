public class Scene 
{
    // Constructor and its parameter variable. Used to store and display dialog to appear on the output when first displayed.
    public string story;

    public Scene(string paramStory)
    {
        story = paramStory;
    }

    // Scenes used  by the game model. A new instance is created each time one is needed and then the dialog text is stored in the instance.
    public Scene CommanderFirstDialog;
    public Scene CommanderSecondDialog;
    public Scene CommanderThirdDialog;
    public Scene CommanderFourthDialog;
    public Scene ClueDialog;
    public Scene ClueDialogTwo;
    public Scene BagExamination;
    public Scene CaveEntrance;
    public Scene EnteringCave;
}
