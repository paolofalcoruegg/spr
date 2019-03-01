﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectFollower : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
    }

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);
    }
}
