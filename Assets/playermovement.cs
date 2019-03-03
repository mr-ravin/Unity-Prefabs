using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rbody;
    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        process_keystroke();
    }
    void process_keystroke()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rbody.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rbody.AddRelativeForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rbody.AddRelativeForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down);
        }
    }
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}
