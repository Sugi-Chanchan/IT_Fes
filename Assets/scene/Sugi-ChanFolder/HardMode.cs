using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMode : MonoBehaviour {

    public GameObject td;
    public GameObject en;
    public GameObject pl;
    public GameObject jk;
    public GameObject fd;
	// Use this for initialization
	void Start () {
    
        td = GameObject.FindGameObjectWithTag("tamadashi");
        en = GameObject.FindGameObjectWithTag("Enemy");
        pl = GameObject.FindGameObjectWithTag("Player");
        jk = GameObject.FindGameObjectWithTag("JACKUN");

        if (Bullet_easy.bullet_number == 1)
        {
            en.GetComponent<IntervalSpon>().kankaku = 0;
            Invoke("Fradra", 20);
            td.GetComponent<Tekinotama>().Kankaku = 3;
        }
        if (Bullet_easy.bullet_number == 3)
        {
            en.GetComponent<RandomSplash>().interval = 2f;
            en.transform.localScale = new Vector3(2, 2, 2);
            td.GetComponent<Tekinotama>().Kankaku = 0.3f;
        }
        if (Bullet_easy.bullet_number ==5)
        {
            en.transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
            en.GetComponent<RandomSplash>().interval = 5f;
            td.GetComponent<Tekinotama>().Kankaku = 3;
            en.GetComponent<IntervalSpon>().kankaku = 5;
            pl.GetComponent<BoxCollider>() .size = new Vector3(0.5f, 0.5f, 0.5f);
            jk.transform.localScale = new Vector3(50,50,50);
            pl.GetComponent<Obitcontroller>().speed = 0.5f;
            Invoke("Fradra", 20);

            

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Fradra()
    {
        fd = GameObject.FindGameObjectWithTag("FD");
        fd.GetComponent<FlyDra>().speed = 0.3f;

    }
}
