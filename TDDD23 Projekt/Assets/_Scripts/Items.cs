using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum InteractionType {None, PickUp, Examine, Open}
    public InteractionType type;

    // List of Picked up items
    public List<GameObject> PickedItems = new List<GameObject>();
    
   
    





    //TODO:
    // interagera med dörr. om man har en nyckel så kan man öppna dörren annars meddelande om att man måste
    // hitta nyckel. har man nyckel, dörren öppnas och nyckeln tas bort från listan.
}
