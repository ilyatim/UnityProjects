using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice3 : MonoBehaviour
{
    public float RandomNumber;

    public GameObject RandomObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RandomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        Randomize();
    }

    private void Randomize()
    {
        RandomNumber = Random.Range(1, 10);
        Debug.Log(RandomNumber);
        if (RandomNumber == 3) Debug.Log("Проверка условия");
    }
}
