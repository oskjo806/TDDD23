using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiatePlayer : MonoBehaviour
{

    public GameObject playerPrefab;
    private GameObject player;
    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.activeSceneChanged += ChangedActiveScene;
    }
    private void ChangedActiveScene(Scene current, Scene next)
    {
        string currentName = current.name;

        if (next.name == "Startscreen")
        {
            Instantiate(playerPrefab, new Vector3(2.5f, -3.5f, 0f), transform.rotation);
            player = GameObject.Find("Player(Clone)");
            
        }
        else if (next.name == "Base Room")
        {
            player = GameObject.Find("Player(Clone)");
            player.transform.position = new Vector3(2.5f, -3.5f, 0f);
        }
        else if (next.name == "Level 1")
        {
            player = GameObject.Find("Player(Clone)");
            player.transform.position = new Vector3(56f, 55f, 0f);
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instantiate(playerPrefab, new Vector3(2.5f, -3.5f, 0f), transform.rotation);
        player = GameObject.Find("Player(Clone)");
    }
}
