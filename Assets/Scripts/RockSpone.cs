﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpone : MonoBehaviour {
    public GameObject rock;
    public GameObject bigrock;
    Vector3 vec;
    public GameObject spon;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spone", 0.1f, 0.06f);
        InvokeRepeating("BigSpone", 0.1f, 0.07f);
    }

	
	// Update is called once per frame
	void Update () {

	}
    void Spone()
    {
        Instantiate(rock,new Vector3(-20+40*Random.value, -20+40 * Random.value,spon.transform.position.z-1),Quaternion.identity);
       
    }
    void BigSpone()
    {
        Instantiate(bigrock, new Vector3(-20 + 40 * Random.value, -20 + 40 * Random.value, spon.transform.position.z-10), Quaternion.identity);
    }
}
