using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item{
    public int id;
    public string name;
    public string description;
    public Texture2D icon;

    public Item(int id, string name, string description){
        this.id = id;
        this.name = name;
        this.description = description;
        icon = Resources.Load <Texture2D>("Icons/" + name);
    }

	
}
