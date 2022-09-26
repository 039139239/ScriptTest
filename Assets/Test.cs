
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{


    void Start()
    {
        int[] array = { 40, 50, 20, 60, 90 };

        for (int i = 0; i < 5; i++)
        {
                Debug.Log(array[i]);
            
        }



        for (int i = 4;  i >= 0; i--)
        {
                Debug.Log(array[i]);

        }

    }
    void Update ()
        {

        }
}
