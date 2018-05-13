using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour {

    GameObject sub;

	// Use this for initialization
	void Start () {
        sub = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, 0.6f,Space.World);
        if (transform.position.z >= sub.transform.position.z+61|transform.position.z<=sub.transform.position.z-11|transform.position.y>33|transform.position.y<=-30
            )
        {
            Destroy(gameObject);
        }
	}

}
