using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float add = transform.position.x + transform.position.y + transform.position.z;
        if (add > 70)
        {
            Destroy(gameObject);
        }
    }
}
