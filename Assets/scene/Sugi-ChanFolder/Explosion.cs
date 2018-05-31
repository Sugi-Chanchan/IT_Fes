using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject explosion;
	// Use this for initialization
	void Start () {
        Invoke("EX", 3);
        Invoke("AA", 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void EX()
    {
        Instantiate(explosion, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 4, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 10, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 10, 3), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 10, -3), Quaternion.identity);
        Instantiate(explosion, new Vector3(3, 10, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(3, 10, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 5, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 2, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 2, 3), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 2, -3), Quaternion.identity);
        Instantiate(explosion, new Vector3(-1, 3, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(1, 3, 0), Quaternion.identity);
        Instantiate(explosion, new Vector3(0, 5, -4), Quaternion.identity);
        Instantiate(explosion, new Vector3(4, 7, 4), Quaternion.identity);
        Instantiate(explosion, new Vector3(2, 3, 6), Quaternion.identity);
        Instantiate(explosion, new Vector3(-2, 3, 6), Quaternion.identity);
        Instantiate(explosion, new Vector3(-2, 3, -6), Quaternion.identity);
        Instantiate(explosion, new Vector3(2, 3, -6), Quaternion.identity);
        Instantiate(explosion, new Vector3(2, 3, 0), Quaternion.identity);
    }
    void AA()
    {
        Destroy(gameObject);
    }
}
