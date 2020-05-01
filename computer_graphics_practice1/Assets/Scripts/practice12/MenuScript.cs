using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuScript : MonoBehaviour
{
    public GameObject menuWindow;
    public void StartScene()
    {
        Application.LoadLevel("scene2");
    }

    public void Options(GameObject window)
    {
        window.SetActive(true);
        menuWindow.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SetMenuActive()
    {
        menuWindow.SetActive(true);
    }
}
