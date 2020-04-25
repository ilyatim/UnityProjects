using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;
    private bool flag = false;

    private bool ChangeFlag()
    {
        return flag = !flag;
    }
    void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (flag)
            {
                door.transform.Rotate(0f, 0f, 90f);
                ChangeFlag();
            }
            else
            {
                door.transform.Rotate(0f, 0f, -90f);
                ChangeFlag();
            }
        }
    }
}
