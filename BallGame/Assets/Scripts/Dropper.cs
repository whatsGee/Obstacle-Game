﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    public Transform player;
    public float maxDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update(){
        if (Vector3.Distance (player.position, transform.position) < maxDistance)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
        }
    }
    */
}
