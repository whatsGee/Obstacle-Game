using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;   // Reference to the player GameObject.
    private Vector3 offset; // The distance between the camera and the player.

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;    // Calculate the initial offset between the camera's position and the player's position.
    }

    // LateUpdate is called once per frame after all Update functions have been
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;    // Maintain the same offset between the camera and player throughout the game.
    }
}
