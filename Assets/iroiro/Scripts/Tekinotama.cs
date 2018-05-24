using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tekinotama : MonoBehaviour {
   //JibunとsokudoはAttackという別のスクリプトに渡します
    public GameObject Teki;
    public GameObject Jibun;
    public GameObject Tama;
    public float Kankaku;
    public float Sokudo;


	// Use this for initialization
	void Start () {
        //sceneに出したときに識別できるようにタグをつけておきます。
        Tama.tag = "tama";
        InvokeRepeating("Attack", 0.1f, Kankaku);



	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Attack()
    {
        Instantiate(Tama, Teki.transform.position, Quaternion.identity);
        //tamaというタグがついたオブジェクトを探してAttackというスクリプトを付加させて、最後にタグを外します。
        GameObject ob=GameObject.FindGameObjectWithTag("tama");
        ob.AddComponent<chase>();
        //このnonはただtamaのタグを外すためだけにつけたタグです
        ob.tag = "non";
    }
}
