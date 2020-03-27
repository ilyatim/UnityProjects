using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice6_cube5 : MonoBehaviour
{
    private Vector3 MouseOffSet;
    private float MouseZCoord;

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffSet = gameObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = MouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + MouseOffSet;
    }
}
