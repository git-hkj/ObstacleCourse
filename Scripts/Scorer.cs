using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // a method that's called whenever rigid body collide
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
                {
                    hits++;
                    Debug.Log("Collisions: " + hits);
                }    
    }
}
