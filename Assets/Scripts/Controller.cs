using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    Vector3 up = new Vector3(0, 0.4f, 0);
    Vector3 down = new Vector3(0, -0.4f, 0);
    Vector3 right = new Vector3(0.4f, 0, 0);
    Vector3 left = new Vector3(-0.4f, 0, 0);
    public GameObject Bullet;
    public GameObject WhiteCube;
    public GameObject HevBullet;
  

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(0, 0, 0.4f);
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y<=20)
        {
            transform.Translate(up,Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y >= -20)
        {
            transform.Translate(down,Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 19.8f)
        {
            transform.Translate(right,Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -19.8f)
        {
            transform.Translate(left,Space.World);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Variables.bulletnumber> 0)
            {
                InvokeRepeating("Burst", 0, 0.05f);
                
            }         
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Heavyburst();

            
        }
 
        
    }
    void Burst()
    {
        if (Variables.bulletnumber > 0)
        {
            Instantiate(Bullet,new Vector3(transform.position.x,transform.position.y,transform.position.z+2), Quaternion.identity);
            Variables.bulletnumber -= 1;
        }
       
    }
    void Heavyburst()
    {
        if (Variables.heavybulletcountor > 0)
        {
            Instantiate(HevBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z +4), Quaternion.identity);
            Variables.heavybulletcountor -= 1;
        }
    }
}