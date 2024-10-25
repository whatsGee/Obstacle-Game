using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    public GameObject walls;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.red;
            EndGame();
        }
    }

    void EndGame()
    {
        // Stop the ball's movement by setting its velocity to zero
        GetComponent<Rigidbody>().velocity = Vector3.zero;

        // Display the replay UI (you need to create a Canvas with a replay button)
        GameObject.Find("GameOverUI").SetActive(true);
    }
    
}
