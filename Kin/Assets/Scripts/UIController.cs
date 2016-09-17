﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

    public Slider health;
    public Slider stamina;
    // Add clock
    // Add Boss Health
	
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void setMaxHealth(int maxHealth)
    {
        health.maxValue = maxHealth;
    }

    void setMaxStamina(int maxStam)
    {
        stamina.maxValue = maxStam;
    }

    void setStamina(int val)
    {
        stamina.value = val;
    }

    int getStamina()
    {
        return (int)stamina.value;
    }

    int getHealth()
    {
        return (int)health.value;
    }

    void setHealth(int val)
    {

        health.value = val;
    }
    
    void setClock(int time)
    {
        print(@"No clock yet. ¯\_(ツ)_/¯");
    }

    int getClock()
    {
        print(@"No clock yet.¯\_(ツ)_/¯");
        return 0;
    }

    void setBossHealth()
    {
        print(@"No boss health yet.¯\_(ツ)_/¯");
    }

    int getBossHealth()
    {
        print(@"No boss health yet.¯\_(ツ)_/¯");
        return 0;
    }
}
