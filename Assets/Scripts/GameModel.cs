
public class GameModel
{ 
    private static PlayerManager _playerManager;
    private static StoryManager _storyManager;

    public static PlayerManager PlayerManager
    {
        get { return _playerManager; }
    }

    public static StoryManager StoryManager
    {
        get { return _storyManager; }
    }

    public GameModel()
    {
        _playerManager = new PlayerManager();
        _storyManager = new StoryManager();
    }
}
