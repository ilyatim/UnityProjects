using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnScreen : MonoBehaviour
{
    public string[] tags;
    private bool isOn = false;
    bool GetTag (string curTag) 
    {
        bool result = false;
        foreach(string t in tags)
        {
            if(t == curTag) result = true;
        }
        return result;
    }
    void OnTriggerStay(Collider collider)
    {
        if (GetTag(collider.tag))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOn)
                {
                    collider.GetComponent<Renderer>().material.color = Color.white;
                    isOn = false;
                }
                else
                {
                    collider.GetComponent<Renderer>().material.color = Color.black;
                    isOn = true;
                }
            } 
        }
    }
}
