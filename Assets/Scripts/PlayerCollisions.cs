using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 3);
        if(Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if(hit.collider.gameObject.tag == "playerDoor")
            {
                Debug.Log("We are facing the door");
            }
        }
    }

    // Custom collision detection function for the player character
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the player has collided with a game object tagged as "playerDoor"
        if (hit.gameObject.tag == "playerDoor")
        {
            // Log a message to the console indicating the player has walked into the door
            Debug.Log("Walked into the door.");
        }
    }
}
