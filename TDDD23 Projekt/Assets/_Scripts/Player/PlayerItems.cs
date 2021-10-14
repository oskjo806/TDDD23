using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    // Start is called before the first frame update
    public enum InteractionType { None, PickUp, Examine, Open }
    public InteractionType type;
    private GameObject item;
    

    // List of Picked up items
    public List<GameObject> PickedItems = new List<GameObject>();

   

    public void Interact()
    {
        switch (type)
        {
            case InteractionType.PickUp:
                //add item in players inventory
                PickedupItems(gameObject);
                Debug.Log("PICK UP");
                gameObject.SetActive(false);
                break;
            case InteractionType.Examine:
                Debug.Log("EXAMINE");
                break;
            case InteractionType.Open:
                if (PickedItems.Contains(GameObject.Find("SilverKey")))
                {

                }
                else
                {
                    Debug.Log("find the key");
                }
                Debug.Log("OPEN");
                break;
            case InteractionType.None:
                Debug.Log("NULL ITEM");
                break;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            item = collision.gameObject;
           
        }
        
    }

    public void PickedupItems(GameObject item)
    {
        PickedItems.Add(item);
    }




    //TODO:
    // interagera med dörr. om man har en nyckel så kan man öppna dörren annars meddelande om att man måste
    // hitta nyckel. har man nyckel, dörren öppnas och nyckeln tas bort från listan.
}

