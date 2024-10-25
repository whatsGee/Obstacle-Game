using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamWall : MonoBehaviour
{
    Collider collider;

    public Transform player;
    public float maxDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        collider.isTrigger = false;
    }

    // Update is called once per frame
    void Update(){
        if (Vector3.Distance (player.position, transform.position) < maxDistance)
        {
            collider.isTrigger = true;
        }
    }
}
