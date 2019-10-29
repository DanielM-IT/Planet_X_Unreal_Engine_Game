using System.Linq;
using System.Collections.Generic;


public class StoryManager 
{
    private DataService Db = new DataService("PlanetXData.db");


    public DataService DB
    {
        get
        {
            return Db;
        }
    }


    public StoryManager()
    {
        DB.CreateDB(new[]
        {
            typeof(StorySection),
            typeof(Dialogue)
        });


        CreateObjectiveStorySection("ObjectivesScene", "ObjectiveDialogueOne");
        CreateForestStorySection("ForestScene", "ForestDialogueOne");
        CreateCaveEntranceStorySection("CaveEntranceScene", "CaveEntranceDialogueOne");
    }


    public void CreateObjectiveStorySection(string pSectionName, string pFirstDialogueName)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,
            FirstDialogueName = pFirstDialogueName,
        });

        StorySection theStorySection = Db.Connection.Table<StorySection>().Where(
            x => x.SectionName == pSectionName
            ).ToList<StorySection>().FirstOrDefault<StorySection>();

        var lcObjectiveDialogueOne = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ObjectiveDialogueOne",
            CurrentDialogue = "\n" + "As earth’s population grows too large for the planet to sustain, man began exploring the wider universe looking for new planets to inhabit." + "\n" + "\n" +
            "In a remote region a colonist ship arrives in an uncharted system. Being critically damaged by a close encounter with an asteroid field the crew were forced to immediately make landfall." + "\n" + "\n" +
            "It did not take long for the crew to discover that the communication equipment did not work and the ship too severely damaged to lift off again.With options limited the ships occupants began construction of a new settlement and set out to explore their new home." +
            "\n" + "\n" + "They soon realised they were not alone…" + "\n" + "\n" + "(next) to continue"
        };
        Db.Connection.Insert(lcObjectiveDialogueOne);

        theStorySection.FirstDialogueName = lcObjectiveDialogueOne.DialogueName;
        Db.Connection.InsertOrReplace(theStorySection);

        var lcObjectiveDialogueTwo = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ObjectiveDialogueTwo",
            CurrentDialogue = "Greetings ranger. Are you ready for your next assignment?" + "\n" + "\n" + "(yes)"
        };
        Db.Connection.Insert(lcObjectiveDialogueTwo);

        var lcObjectiveDialogueThree = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ObjectiveDialogueThree",
            CurrentDialogue = "Very good. I have recently lost contact with the last scouting party and need someone to track them down. I believe your skills are suited to the job." + "\n" + "\n" + "(continue)"
        };
        Db.Connection.Insert(lcObjectiveDialogueThree);


        var lcObjectiveDialogueFour = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ObjectiveDialogueFour",
            CurrentDialogue = "They were last seen heading into the nearby forest. This leaves three directions they could have gone. I am relying on you to see this through. Scout around their last location and search for clues as to their direction." +
            "\n" + "\n" + "(north) -- begin searching north" + "\n" + "\n" + "(west) -- begin searching west" + "\n" + "\n" + "(east) -- begin searching east"
        };
        Db.Connection.Insert(lcObjectiveDialogueFour);


        var lcObjectiveDialogueFive = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ObjectiveDialogueFive",
            CurrentDialogue = "Good choice and good luck."
        };
        Db.Connection.Insert(lcObjectiveDialogueFive);
    }


    public void CreateForestStorySection(string pSectionName, string pFirstDialogueName)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,
            FirstDialogueName = pFirstDialogueName,
        });

        StorySection theStorySection = Db.Connection.Table<StorySection>().Where(
        x => x.SectionName == pSectionName
        ).ToList<StorySection>().FirstOrDefault<StorySection>();

        var lcForestDialogueOne = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ForestDialogueOne",
            CurrentDialogue = "It looks like footprints lead in a northern direction." + "\n" + "\n" + "(continue)"
        };
        Db.Connection.Insert(lcForestDialogueOne);

        theStorySection.FirstDialogueName = lcForestDialogueOne.DialogueName;
        Db.Connection.InsertOrReplace(theStorySection);

        var lcForestDialogueTwo = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ForestDialogueTwo",
            CurrentDialogue = "Follow them?" + "\n" + "\n" + "(definitely)"
        };
        Db.Connection.Insert(lcForestDialogueTwo);

        var lcForestDialogueThree = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "ForestDialogueThree",
            CurrentDialogue = "You follow the footprints toward the northern forest edge."
        };
        Db.Connection.Insert(lcForestDialogueThree);
        
    }

    public void CreateCaveEntranceStorySection(string pSectionName, string pFirstDialogueName)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,
            FirstDialogueName = pFirstDialogueName,
        });

        StorySection theStorySection = Db.Connection.Table<StorySection>().Where(
        x => x.SectionName == pSectionName
        ).ToList<StorySection>().FirstOrDefault<StorySection>();

        var lcCaveEntranceDialogueOne = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "CaveEntranceDialogueOne",
            CurrentDialogue = "At last I must be getting close. These bags belong to members of the scouting team." + "\n" + "\n" + "Have a closer look?" + "\n" + "\n" + "(yes) -- Look inside the bags" + "\n" + "(no) -- Examine the cave entrance"
        };
        Db.Connection.Insert(lcCaveEntranceDialogueOne);

        theStorySection.FirstDialogueName = lcCaveEntranceDialogueOne.DialogueName;
        Db.Connection.InsertOrReplace(theStorySection);

        var lcCaveEntranceDialogueTwo = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "CaveEntranceDialogueTwo",
            CurrentDialogue = "Opening the bags is a terrible idea. Their rations have deteriorated severely indicating they have been sitting there quite some time. What could have happend to the owners?" + "\n" + "\n" + "(examine) -- Examine the cave entrance?"
        };
        Db.Connection.Insert(lcCaveEntranceDialogueTwo);

        var lcCaveEntranceDialogueThree = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "CaveEntranceDialogueThree",
            CurrentDialogue = "Enter the cave?" + "\n" + "\n" + "(sure)"
        };
        Db.Connection.Insert(lcCaveEntranceDialogueThree);


        var lcCaveEntranceDialogueFour = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "CaveEntranceDialogueFour",
            CurrentDialogue = "You enter the cave uncertain what you may find."
        };
        Db.Connection.Insert(lcCaveEntranceDialogueFour);


        var lcCaveEntranceDialogueFive = new Dialogue
        {
            SectionName = theStorySection.SectionName,
            DialogueName = "CaveEntranceDialogueFive",
            CurrentDialogue = "Enter the cave?" + "\n" + "\n" + "(sure)."
        };
        Db.Connection.Insert(lcCaveEntranceDialogueFive);
    }

    public void getDialogue()
    {
        Dialogue dialogue = Db.Connection.Table<Dialogue>().Where(
               x => x.DialogueName == GameManager.gameManager.currentDialogueName
               ).ToList<Dialogue>().FirstOrDefault<Dialogue>();

        GameManager.gameManager.currentDialogue = dialogue.CurrentDialogue;
    }

    public void getNewStorySection()
    {
        StorySection currentStorySection = Db.Connection.Table<StorySection>().Where(
            x => x.SectionName == GameManager.gameManager.currentScene
            ).ToList<StorySection>().FirstOrDefault<StorySection>();
    }
}


