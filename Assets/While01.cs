using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    int counter = 1;
    void Start()
    {
        while (counter < 100)
        {
            counter++;
            Debug.Log(counter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
