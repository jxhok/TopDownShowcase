using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for horizontal and vertical input
        //move the player based on that imput
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        //Velocity is a Vector2 variable, wich stores
        //2 floats, c and y
        GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * moveSpeed;
    }
}
