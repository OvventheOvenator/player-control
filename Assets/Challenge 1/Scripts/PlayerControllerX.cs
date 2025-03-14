using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 25f;
    public float rotationSpeed = 60f;
    public float verticalInput;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
         transform.Rotate(Vector3.right, rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
