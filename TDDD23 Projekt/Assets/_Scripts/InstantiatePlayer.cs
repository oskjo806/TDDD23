using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiatePlayer : MonoBehaviour
{

    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Awake()
    {   
        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "Base Room")
        {
            Instantiate(playerPrefab, new Vector3(2.5f, -3.5f, 0f), transform.rotation);
        }
        else if(sceneName == "Level 1")
        {
            Instantiate(playerPrefab, new Vector3(45f, 59f, 0f), transform.rotation);
        }
    }
}
