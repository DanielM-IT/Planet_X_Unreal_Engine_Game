
public class StoryManager
    {
    // Players current scene
    public Scene currentScene;

    // Players first scene
    public Scene firstScene;

    // Players second scene
    public Scene secondScene;

    // Players third scene
    public Scene thirdScene;

    public StoryManager()
    {
        createObjectives();
    }

    // This is where I move from one dialog/scene to another giving the dialog that will be displayed on sceen in the text field. It will first check which is the current active scene.
    private void createObjectives()
    {
        string activeScene = GameManager._gameManager.currentActiveScene();

        if (activeScene == "ObjectivesScene")
        {
            firstScene = new Scene("As earth’s population grows too large for the planet to sustain, man began exploring the wider universe looking for new planets to inhabit." + "\n" + "\n" +
                "In a remote region a colonist ship arrives in an uncharted system. Being critically damaged by a close encounter with an asteroid field the crew were forced to immediately make landfall." + "\n" + "\n" +
                "It did not take long for the crew to discover that the communication equipment did not work and the ship too severely damaged to lift off again.With options limited the ships occupants began construction of a new settlement and set out to explore their new home." +
                "\n" + "\n" + "They soon realised they were not alone…" + "\n" + "\n" + "(next) to continue");
            firstScene.CommanderFirstDialog = new Scene("Greetings ranger. Are you ready for your next assignment?" + "\n" + "\n" + "(yes)");
            firstScene.CommanderFirstDialog.CommanderSecondDialog = new Scene("Very good. I have recently lost contact with the last scouting party and need someone to track them down. I believe your skills are suited to the job." + "\n" + "\n" + "(continue)");
            firstScene.CommanderFirstDialog.CommanderSecondDialog.CommanderThirdDialog = new Scene("They were last seen heading into the nearby forest. This leaves three directions they could have gone. I am relying on you to see this through. Scout around their last location and search for clues as to their direction." +
                "\n" + "\n" + "(north) -- begin searching north" + "\n" + "\n" + "(west) -- begin searching west" + "\n" + "\n" + "(east) -- begin searching east");
            firstScene.CommanderFirstDialog.CommanderSecondDialog.CommanderThirdDialog.CommanderFourthDialog = new Scene("Good choice and good luck.");

            currentScene = firstScene;
        }
        else if (activeScene == "ForestScene")
        {
            secondScene = new Scene("It looks like footprints lead into the the northern direction." + "\n" + "\n" + "(continue)");
            secondScene.ClueDialog = new Scene("Follow them?" + "\n" + "\n" + "(yes)");
            secondScene.ClueDialog.ClueDialogTwo = new Scene("You follow the footprints toward the northern forest edge.");

            currentScene = secondScene;
        }
        else if (activeScene == "CaveEntranceScene")
        {
            thirdScene = new Scene("At last I must be getting close. These bags belong to members of the scouting team." + "\n" + "\n" + "Have a closer look?" + "\n" + "\n" + "(yes) -- Look inside the bags" + "\n" + "(no) -- Examine the cave entrance");
            thirdScene.BagExamination = new Scene("Opening the bags is a terrible idea. Their rations have deteriorated severely indicating they have been sitting there quite some time. What could have happend to the owners?" + "\n" + "\n" + "(examine) -- Examine the cave entrance?");
            thirdScene.BagExamination.CaveEntrance = new Scene("Enter the cave?" + "\n" + "\n" + "(sure)");
            thirdScene.BagExamination.CaveEntrance.EnteringCave = new Scene("You enter the cave uncertain what you may find.");
            thirdScene.CaveEntrance = new Scene("Enter the cave?" + "\n" + "\n" + "(sure)");
            thirdScene.CaveEntrance.EnteringCave = new Scene("You enter the cave uncertain what you may find.");

            currentScene = thirdScene;
        }
    }

}

