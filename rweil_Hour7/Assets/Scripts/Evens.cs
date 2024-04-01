using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Loop through even numbers from 22 to 100
        for (int i = 22; i <= 100; i += 2)
        {
            Debug.Log(i);
        }
    }
}
