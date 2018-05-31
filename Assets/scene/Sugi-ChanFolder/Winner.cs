using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour {

    public GameObject explosion;
    GameObject pl;
	// Use this for initialization
	void Start () {
        Invoke("Win", 60);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Win()
    {
        SceneManager.LoadScene("SSSSample");


       
    }

}
