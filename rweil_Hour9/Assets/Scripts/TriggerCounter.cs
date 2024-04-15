using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCounter : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        Debug.Log("Collision number: " + collisionCount);
    }
}
