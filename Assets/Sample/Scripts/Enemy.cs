﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int hp;

  

	// Use this for initialization
	void Start () {
        hp = 100;
   
    }

    // Update is called once per frame
    void Update () {
		
	}
 void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(1, 0, 0);

    }



}