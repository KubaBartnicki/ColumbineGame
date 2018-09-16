using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour{
    public static List<Item> items = new List<Item>();





    public void Awake(){
        items.Add(new Item(0, "Empty Slot", " "));
        items.Add(new Item(1, "Main Key", "This key can open main shool doors"));
        items.Add(new Item(2, "Classroom Key", "This key can open every class room in the shool"));
        items.Add(new Item(3, "M4", "Short version soviet rifle AKM using 7,62 x 39 bullets"));
        items.Add(new Item(4, "First aid kit", "You can heal your self or your friend"));
        items.Add(new Item(5, "Pipe bomb", "Handmade bomb"));
    }

}
