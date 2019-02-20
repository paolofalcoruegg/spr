﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float timePassed = 0;
    public float timer = 0;

    public void ResetTimer()
    {
        timer = timePassed;
    }

    public void StopTimer()
    {
        timer = timePassed - timer;
        Debug.Log("The time taken until train perceived as passed: " + timer);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
    }
}