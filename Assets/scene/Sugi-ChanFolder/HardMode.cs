using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMode : MonoBehaviour
{

    public GameObject td;
    public GameObject en;
    public GameObject pl;
    public GameObject jk;
    public GameObject fd;
    public Camera cmr;
    // Use this for initialization
    void Start()
    {

        td = GameObject.FindGameObjectWithTag("tamadashi");
        en = GameObject.FindGameObjectWithTag("Enemy");
        pl = GameObject.FindGameObjectWithTag("Player");
        jk = GameObject.FindGameObjectWithTag("JACKUN");
        cmr = GameObject.Find("JKCamera").GetComponent< Camera >();

        if (Bullet_easy.bullet_number == 1)
        {
            en.GetComponent<IntervalSpon>().kankaku = 0;
            Invoke("Fradra3", 20);
            td.GetComponent<Tekinotama>().Kankaku = 3;
            en.transform.localScale = new Vector3(1, 1, 1);
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(100, 100, 100);
            pl.GetComponent<Obitcontroller>().speed = 1f;
            en.GetComponent<RandomSplash>().interval = 3f;
            cmr.farClipPlane = 200;

        }
        if (Bullet_easy.bullet_number == 2)
        {
            en.transform.localScale = new Vector3(1, 1, 1);
            en.GetComponent<RandomSplash>().interval = 2f;
            td.GetComponent<Tekinotama>().Kankaku = 1;
            en.GetComponent<IntervalSpon>().kankaku = 2;
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(100, 100, 100);
            pl.GetComponent<Obitcontroller>().speed = 1f;
            Invoke("Fradra1", 20);
            cmr.farClipPlane = 200;

        }
        if (Bullet_easy.bullet_number == 3)
        {
            en.GetComponent<RandomSplash>().interval = 0.6f;
            en.transform.localScale = new Vector3(2, 2, 2);
            td.GetComponent<Tekinotama>().Kankaku = 0.1f;
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(100, 100, 100);
            pl.GetComponent<Obitcontroller>().speed = 1f;
            Invoke("Fradra2", 20);
            en.GetComponent<IntervalSpon>().kankaku = 1;
            cmr.farClipPlane = 200;
        }
        if (Bullet_easy.bullet_number == 5)
        {
            en.transform.localScale = new Vector3(2f, 2f, 2f);
            en.GetComponent<RandomSplash>().interval = 5f;
            td.GetComponent<Tekinotama>().Kankaku = 1;
            en.GetComponent<IntervalSpon>().kankaku = 5;
            pl.GetComponent<BoxCollider>().size = new Vector3(0.5f, 0.5f, 0.5f);
            jk.transform.localScale = new Vector3(50, 50, 50);
            pl.GetComponent<Obitcontroller>().speed = 0.5f;
            Invoke("Fradra", 20);
            cmr.farClipPlane = 200;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Fradra()
    {
        fd = GameObject.FindGameObjectWithTag("FD");
        fd.GetComponent<FlyDra>().speed = 0.1f;

    }
    void Fradra1()
    {
        fd = GameObject.FindGameObjectWithTag("FD");
        fd.GetComponent<FlyDra>().speed = 0.5f;
    }
    void Fradra2()
    {
        fd = GameObject.FindGameObjectWithTag("FD");
        fd.GetComponent<FlyDra>().speed = 0.6f;
    }
    void Fradra3()
    {
        fd = GameObject.FindGameObjectWithTag("FD");
        fd.GetComponent<FlyDra>().speed = 0.2f;
    }
}
