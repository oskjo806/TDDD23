using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public Tile openedDoor,floorTile,closedDoorLeftWallTop, closedDoorLeftWallBot;
    private CompositeCollider2D doorsCol;
    private Tilemap doors;
    private List<Vector3> doorPos = new List<Vector3>();

    void Start()
    {
        doorsCol = GetComponent<CompositeCollider2D>();
        doors = GetComponent<Tilemap>();

        StartCoroutine(passiveMe(2));

        IEnumerator passiveMe(int secs)
        {
            yield return new WaitForSeconds(secs);
            OpenDoors();
        }
    }
    void OpenDoors()
    {
        doorsCol.isTrigger = true;
        doors.SwapTile(closedDoorLeftWallTop, openedDoor);
        doors.SwapTile(closedDoorLeftWallBot, floorTile);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("player enter");
        if (doorsCol.name == "Doors_level1")
        {
            Debug.Log("player enter");
            SceneManager.LoadScene("Level 1");
        }
        else if(doorsCol.name == "Doors_level2")
        {
            //lOAD SCENE Level 2
        }
        else if (doorsCol.name == "Doors_Bossroom")
        {
            //lOAD SCENE BossRoom
        }

        //Transfer player to next Level;
    }
}
