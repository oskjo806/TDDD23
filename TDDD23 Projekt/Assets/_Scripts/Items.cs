using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum InteractionType {None, PickUp, Examine}
    public InteractionType type;

    // List of Picked up items
    public List<GameObject> PickedItems = new List<GameObject>();

    void Update()
    {
        if(InteractInput())
        {
            GetComponent<Items>().Interact();
        }
    }
   
    public void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    public void Interact()
    {
        switch(type)
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
            case InteractionType.None:
                Debug.Log("NULL ITEM");
                break;

        }
    }

    public void PickedupItems(GameObject item)
    {
        PickedItems.Add(item);
    }

    private bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    //TODO:
    // interagera med dörr. om man har en nyckel så kan man öppna dörren annars meddelande om att man måste
    // hitta nyckel. har man nyckel, dörren öppnas och nyckeln tas bort från listan.
}
