using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delive : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        Debug.Log("What was that?!");
    }
}
