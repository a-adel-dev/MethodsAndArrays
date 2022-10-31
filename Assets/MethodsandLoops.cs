using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsandLoops : MonoBehaviour
{

    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {

        HideObjects();

        CountObjects();
    }

    private void CountObjects()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Debug.Log(i);
        }
    }

    void HideObjects()
    {
        foreach (GameObject myObject in objects)
        {
            myObject.SetActive(false);
            Debug.Log(myObject.name + " is disabled");
        }
    }
}
