using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene 
{
    public string story;


    public Scene(string paramStory)
    {
        story = paramStory;
    }

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
