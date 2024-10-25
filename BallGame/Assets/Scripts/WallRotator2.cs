using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotator2 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector3 (0, -100, 0) * Time.deltaTime);   // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
    }
}
