using UnityEngine;

public class PlayerController : MonoBehaviour
{ //"float" is a speed variable //"private or puplic" is an acces modifier
    private float speed = 20.0f; //the "f" is for Computer to understand this is float)
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}

//deltatime: The amount of seconds took for the engine to process previous frame
//multiply (*) operator: multiplies its inputs and calculates the result.
//words starting with a lowercase are variables