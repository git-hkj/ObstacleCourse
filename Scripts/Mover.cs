using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float  moveSpeed = 0f;
    [SerializeField] Rigidbody refRB;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(-100,0,100);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //to display instruction to player on the console
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("To move the player use 'W' 'A' 'S' 'D'");
    }

    //defining controls to move the player
    void MovePlayer()
    {

        //float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //transform.Translate(-xValue, 0.0f, zValue);
        Vector3 m_Input = new Vector3(-1.0f*Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        refRB.MovePosition(transform.position + m_Input * Time.deltaTime * moveSpeed);
    }
}
