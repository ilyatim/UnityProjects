using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice6_cube3 : MonoBehaviour
{
    private Renderer RendererProp;
    // Start is called before the first frame update
    void Start()
    {
        RendererProp = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        RendererProp.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        RendererProp.material.color = Color.blue;
    }
}
