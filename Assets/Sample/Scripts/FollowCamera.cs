using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public GameObject parent;
    GameObject cmr;
    public GameObject spon;

    private void Start()
    {
    cmr = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update () {
        Vector3 vec = parent.transform.position;
        vec.z -= 5;
        cmr.transform.position=vec;
        spon.transform.position = new Vector3(0,0,parent.transform.position.z+60);
    }
}
