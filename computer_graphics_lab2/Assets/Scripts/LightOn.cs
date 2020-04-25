using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public Light lightPoint1;
    public Light lightPoint2;
    public Light lightPoint3;
    public Light lightPoint4;

    private bool hasPlayer;
    
    private void Update() {
        if (hasPlayer && Input.GetKeyDown("e")) 
        {
            if (CheckLight())
            {
                SetLightDisable();
            }
            else
            {
                SetLightEnable();
            }
        }
    }
 
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            hasPlayer = true;
        }
    }
 
    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            hasPlayer = false;
        }
    }

    private bool CheckLight()
    {
        return lightPoint1.enabled &&
               lightPoint2.enabled &&
               lightPoint3.enabled &&
               lightPoint4.enabled;
    }

    private void SetLightEnable()
    {
        lightPoint1.enabled = true;
        lightPoint2.enabled = true;
        lightPoint3.enabled = true;
        lightPoint4.enabled = true;
    }

    private void SetLightDisable()
    {
        lightPoint1.enabled = false;
        lightPoint2.enabled = false;
        lightPoint3.enabled = false;
        lightPoint4D.enabled = false;
    }
}
