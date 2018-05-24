using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public GameObject obst;
    public float interval;
    public int x;
    public int y;
    public int z;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spone", 0.1f, interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spone()
    {
        Instantiate(obst, new Vector3(x, y, z), Quaternion.identity);
    }
}
