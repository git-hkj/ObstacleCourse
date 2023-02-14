using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // a method that's called whenever rigid body collide
    //                                        | give the details of the other body that collided  
   private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            // a function to access a particular component
            //              |name of the component
            GetComponent<MeshRenderer>().material.color = Color.red;
            // self 
            gameObject.tag = "Hit";
        }
        

    }
}
