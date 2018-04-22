﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    [SerializeField] private float temperature = 20f;
    [SerializeField] private float boilingTemp = 100f;//temperature the pasta cooks
    [SerializeField] private float coolingTemp = 0.5f;//every so often, how much heat does the pot lose

    private int pastaAdded = 0, tomatosAdded = 0, onionsAdded = 0;
    private float timer;
    private float maxTimer = 3f;//3 seconds
    private float health = 100;
    private bool broken = false;

    public float Temperature
    {
        get
        {
            return temperature;
        }
        
    }

    public int PastaAdded
    {
        get
        {
            return pastaAdded;
        }

        set
        {
            pastaAdded = value;
        }
    }

    public int TomatosAdded
    {
        get
        {
            return tomatosAdded;
        }

        set
        {
            tomatosAdded = value;
        }
    }

    public int OnionsAdded
    {
        get
        {
            return onionsAdded;
        }

        set
        {
            onionsAdded = value;
        }
    }

    public float BoilingTemp
    {
        get
        {
            return boilingTemp;
        }

        set
        {
            boilingTemp = value;
        }
    }

    public bool Broken
    {
        get
        {
            return broken;
        }

        set
        {
            broken = value;
        }
    }
     

    // Use this for initialization
    void Start()
    {
        timer = maxTimer;
    }

    public void heatUp(float damage)
    {
        temperature += damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            temperature -= coolingTemp;
            timer = maxTimer;
        }

        if (health < 0 && !broken) broken = true;
    }
}