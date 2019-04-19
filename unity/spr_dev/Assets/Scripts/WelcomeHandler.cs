﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeHandler : MonoBehaviour
{
    public bool isActive = true;

    Countdown countdown;
    FreeNavigateHandler freeNavigateHandler;

    // Start is called before the first frame update
    void Start()
    {
        countdown = GameObject.Find("Countdown").GetComponent<Countdown>();
        freeNavigateHandler = GameObject.Find("Free Navigate").GetComponent<FreeNavigateHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}