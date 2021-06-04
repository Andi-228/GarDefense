using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shreder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collisionObj)
    {
        Debug.Log("Shred");
        Destroy(collisionObj.gameObject);
    }
}