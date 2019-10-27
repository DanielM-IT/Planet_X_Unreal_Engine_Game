using System.Collections;
using System.Collections.Generic;

public class StoryManager 
{
    private DataService Db = new DataService("PlanetXData.db");
    private Dialogue _FirstDialogue;

    public DataService DB
    {
        get
        {
            return Db;
        }
    }

    public Dialogue FirstDialogue
    {
        get
        {
            return _FirstDialogue;
        }

    }

    public StoryManager()
    {
        DB.CreateDB(new[]
        {
            typeof(StorySection),
            typeof(Dialogue)
        });


        CreateObjectiveStorySection("ObjectivesScene", "ObjectiveDialogOne", GameManager.gameManager.username);
        CreateForestStorySection("ForestScene", "ForestDialogOne", GameManager.gameManager.username);
        CreateCaveEntranceStorySection("CaveEntranceScene", "CaveEntranceDialogOne", GameManager.gameManager.username);
    }

    public void CreateObjectiveStorySection(string pSectionName, string pFirstDialogueName, string pPlayerUsername)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,

        });
    }

    public void CreateForestStorySection(string pSectionName, string pFirstDialogueName, string pPlayerUsername)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,

        });
    }

    public void CreateCaveEntranceStorySection(string pSectionName, string pFirstDialogueName, string pPlayerUsername)
    {
        DB.InsertIfDoesNotExist<StorySection>(new StorySection
        {
            SectionName = pSectionName,

        });
    }

}
