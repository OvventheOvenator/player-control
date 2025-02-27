using UnityEngine;

public class PlayerController : MonoBehaviour
{ //"float" is a speed variable //"private or puplic" is an acces modifier
    public float speed = 5.0f; //the "f" is for Computer to understand this is float)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

//deltatime: The amount of seconds took for the engine to process previous frame
//multiply (*) operator: multiplies its inputs and calculates the result.