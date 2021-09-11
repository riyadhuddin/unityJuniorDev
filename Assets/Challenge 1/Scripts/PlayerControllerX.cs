using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    private GameObject helice;
    // Start is called before the first frame update
    void Start()
    {
        helice = GameObject.Find("Propeller");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*// get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime *  speed * verticalInput);
        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontalInput);
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.left * rotationSpeed * horizontalInput * Time.deltaTime);*/

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        helice.transform.Rotate(Vector3.forward, 5000.0f * Time.deltaTime);

    }
}
