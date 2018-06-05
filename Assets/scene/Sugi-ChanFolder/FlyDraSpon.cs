﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDraSpon : MonoBehaviour {

    public GameObject flydra;
    GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        Invoke("Appear", 10);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Appear()
    { Vector3 a = player.transform.position;
        a.x = a.x * 0.9f;a.z = a.z * 0.9f;
        a.y += 20;
        Instantiate(flydra, a, Quaternion.identity);
    }
}
