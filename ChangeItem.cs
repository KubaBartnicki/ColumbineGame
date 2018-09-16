using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour {
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    //   public static GameObject slot4;
    //   public static GameObject slot5;
    int index;
    public void SetItem(int index)
    {
        this.index = index;
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
        if (index == 0)
        {
            slot1.SetActive(false);
            slot2.SetActive(false);
            slot3.SetActive(false);
            //        slot4.SetActive(false);
            //       slot5.SetActive(false);

        }
        if (index == 1)
        {
            slot1.SetActive(true);
            slot2.SetActive(false);
            slot3.SetActive(false);
            //        slot4.SetActive(false);
            //        slot5.SetActive(false);

        }
        if (index == 2)
        {
            slot1.SetActive(false);
            slot2.SetActive(true);
            slot3.SetActive(false);
            Debug.Log("asdasdasd");
            //         slot4.SetActive(false);
            //         slot5.SetActive(false);

        }
        if (index == 3)
        {
            slot1.SetActive(false);
            slot2.SetActive(false);
            slot3.SetActive(true);
            Debug.Log("asdasdasd");
            //        slot4.SetActive(false);
            //       slot5.SetActive(false);

        }
    }
}
