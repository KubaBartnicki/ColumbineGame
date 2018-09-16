using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {
    public GameObject item;
    private bool isOnTrigger;
    public GUISkin infoSkin;
    public Equipment equipment;
    private int id;

    private void OnTriggerEnter(Collider otherObject){

        if (otherObject.tag.Equals("Item")){

            item = otherObject.gameObject;
            isOnTrigger = true;
        }
    }
    private void OnTriggerExit(Collider otherObject)
    {

        if (otherObject.tag.Equals("Item"))
        {
            item = null;
            isOnTrigger = false;
        }
    }

    public void Update(){
        if (isOnTrigger){
            if (Input.GetKeyDown(KeyCode.E)){
                id = item.GetComponent<ItemID>().itemId;
                for (int x=0; x<equipment.items.Count; x++){
                    if (equipment.items[x].id == 0){

                        equipment.items[x] = ItemsList.items[id];

                        Destroy(item);
                        isOnTrigger = false;
                        break;
                    }
                }
            }
        }
    }

    private void OnGUI(){
        if (isOnTrigger){
            GUI.Box(new Rect((Screen.width / 2)-100, Screen.height / 2, 300, 200), "Podnies E " + item.GetComponent<ItemID>().name, infoSkin.GetStyle("PickUp"));
        }

    }

}
