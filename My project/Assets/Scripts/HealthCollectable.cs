using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("object that entered the trigger is:" + other);
    }
}
