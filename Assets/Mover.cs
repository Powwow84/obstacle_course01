using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // [SerializeField] float xValue = 0.00f;
    [SerializeField] float moveSpeed = 10.0f;
        
 



    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();    
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use the arrow keys to move");
        Debug.Log("You can also use asdw");   
    }

    void MovePlayer() 
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

}
