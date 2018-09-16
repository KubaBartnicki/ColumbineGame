using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour {
    public ChangeItem changeItem;

    public List<Item> items = new List<Item>();
    private bool isEquipmentShown = false;

    public GUISkin skin;
    int slots = 5;
    int itemInHands;
    private void Start(){
        for(int x =0;x<slots ;x++ )
        items.Add(new Item(0, "Empty Slot", " "));

    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.Q)){
            isEquipmentShown = !isEquipmentShown;
        }
        if (Input.GetKeyDown(KeyCode.G)){

            items[itemInHands] = new Item(0, "Empty Slot", " ");
            changeItem.SetItem(items[itemInHands].id);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            itemInHands = 0;
            changeItem.SetItem(items[itemInHands].id);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            itemInHands = 1;
            changeItem.SetItem(items[itemInHands].id);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            itemInHands = 2;
            changeItem.SetItem(items[itemInHands].id);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            itemInHands = 3;
            changeItem.SetItem(items[itemInHands].id);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            itemInHands = 4;
            changeItem.SetItem(items[itemInHands].id);
        }
    }


    private void OnGUI(){
        if (isEquipmentShown){
            ShowEquipment();
        }
    }
    private void ShowEquipment(){
        for(int x = 0;x<slots; x++){
            Rect slotPosition = new Rect((Screen.width - 1000) + x * 200, Screen.height / 2, 100, 100);
            if(x == itemInHands){
                GUI.Box(slotPosition, "", skin.GetStyle("EQSlotSelected"));
            }
            else {
                GUI.Box(slotPosition, "", skin.GetStyle("EQSlot"));
            }

            if (items[x].id != 0){
                GUI.DrawTexture(slotPosition, items[x].icon);
            }
        }
    }

}
