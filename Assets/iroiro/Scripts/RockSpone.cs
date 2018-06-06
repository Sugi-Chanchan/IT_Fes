﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpone : MonoBehaviour {
    public GameObject rock;
    public GameObject bigrock;
    public GameObject naiagara;
    public GameObject largeblock;
    Vector3 vec;
    public GameObject spon;



    void Start () {
        //0.03秒に一回　0.1秒間メソッド（処理）"N"を実行する操作を繰り返す
        int a;
        if (Bullet_easy.bullet_number==5)
        {
            a = 4;
        }
        else
        {
            a = Bullet_easy.bullet_number;
        }
        InvokeRepeating("BigSpone", 0.1f, 0.1f/a);

       

        //10秒後にメソッド（処理）"N"を実行する
       
    }

	

	void Update () {

	}
    void Spone()
    {
        //Random.valueは0～1のランダムな値をかえしてくれる
        Instantiate(rock,new Vector3(-20+40*Random.value, -20+40 * Random.value,spon.transform.position.z-10),Quaternion.identity);
       
    }
    void BigSpone()
    {
        Instantiate(bigrock, new Vector3(-20 + 40 * Random.value, -20 + 40 * Random.value, spon.transform.position.z-10), Quaternion.identity);
    }
    void N()
    {
        
        InvokeRepeating("Naiagara", 0.1f, 0.1f);
    }
    void Naiagara()
    {
        Instantiate(naiagara, new Vector3(-10 + 20 * Random.value, -10 + 20 * Random.value, spon.transform.position.z - 5), Quaternion.identity);
    }
    void LargeSpone()
    {
        Instantiate(largeblock, new Vector3(-10 + 20 * Random.value, -10 + 20 * Random.value, spon.transform.position.z - 5), Quaternion.identity);
    }
}
