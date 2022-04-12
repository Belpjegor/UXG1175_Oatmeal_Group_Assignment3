using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//this is a singleton class, meaning one of them in the scene
//this class is to keep tract of the current stade of the game data
public class dataPersistenceManager : MonoBehaviour
{
    [Header ("File Storage Config")]
    [SerializeField] private string fileName;
    private GameData gameData;
    private List<IdataPersistence> dataPersistenceObjects;
    private FileDataHandler dataHandler;
    public static dataPersistenceManager instance { get; private set;}

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Detech more than one Data Persistence Manager in the scene");
        }
        instance = this;
    }

    private void start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

     public void LoadGame()
    {
        //load data from file using file handler
        this.gameData = dataHandler.Load();

        
        //if no data can be loaded, initialise to a new game
        if(this.gameData == null)
        {
            Debug.Log("no data was found, initializing data to defaults");
            NewGame();
        }
        // to push the loaded data to all other scripts that need it
        foreach(IdataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.LoadData(gameData);

        }
       
    }

    public void SaveGame()
    {
        //pass the data to other scripts so that they can update it 
        foreach(IdataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.SaveData(ref gameData);
        }
     

        // save data to a file with data handler
        dataHandler.save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IdataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IdataPersistence> dataPersistenceObjects = 
        FindObjectsOfType<MonoBehaviour>().OfType<IdataPersistence>();
        
        return new List<IdataPersistence>(dataPersistenceObjects);
    }
}
