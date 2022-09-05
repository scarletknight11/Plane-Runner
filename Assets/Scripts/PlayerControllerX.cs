using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed;
    private float verticalInput;
    private float verticalInput2;


    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        verticalInput2 = Input.GetAxis("Vertical2");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput2 * Time.deltaTime);
    }
}
