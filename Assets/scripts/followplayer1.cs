using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player; // Reference to the player object
    public float smoothTime = 0.3f; // Time taken to move camera to target

    private Vector3 velocity = Vector3.zero; // Reference to velocity of camera movement

    private void LateUpdate()
    {

        // Only follow player if they are moving up or down
        if (player.GetComponent<Rigidbody2D>().velocity.y != 0 && transform.position.y !> 0)
        {
            // Create a target position based on player's position
            Vector3 targetPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);

            // Smoothly move the camera to the target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
