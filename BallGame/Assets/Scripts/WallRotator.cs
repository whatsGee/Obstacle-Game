﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector3 (0, 50, 0) * Time.deltaTime);   // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
    }
}
