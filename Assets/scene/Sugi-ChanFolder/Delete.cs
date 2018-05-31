using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Judge", 0.1f, 1);
		
	}
	
	// Update is called once per frame
	void Judge() {
        float add = Mathf.Sqrt(transform.position.x*transform.position.x + transform.position.y*transform.position.y + transform.position.z*transform.position.z);
        if (add > 62)
        {
            Destroy(gameObject);
        }
    }
}
