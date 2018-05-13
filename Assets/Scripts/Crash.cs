using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrash : MonoBehaviour {

    public GameObject a;
    public GameObject b;
    public GameObject enemy;
   // Use this for initialization
	void Start () {
        Variables.enemyhp = 100;
       
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Rock(Clone)" | other.gameObject.name == "BigRock(Clone)")
        {
        Variables.testcounter++;
            Destroy(other.gameObject);
        }
        

    }
}
