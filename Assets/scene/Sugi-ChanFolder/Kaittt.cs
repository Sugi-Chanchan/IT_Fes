﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaittt : MonoBehaviour {

    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(x, y, z), Space.Self);
    }
}
