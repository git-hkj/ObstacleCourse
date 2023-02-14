using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody ARigidBody;
    [SerializeField] float elaspedTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();    //Caching a reference
        renderer.enabled = false;

        ARigidBody = GetComponent<Rigidbody>();      //Caching a reference
        ARigidBody.useGravity= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > elaspedTime)
        {
            renderer.enabled = true;
            ARigidBody.useGravity = true;
        }
    }
}
