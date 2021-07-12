using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{

    public float speed = 0.004f;
    public float dirX;
    public float dirY;
    public bool estado = false;
    public GameObject tutorial;
    // Update is called once per frame
    void Update()
    {  
        if(tutorial.activeSelf == false ){
            estado = true;
        }
        if (estado){
            dirX = Input.GetAxis("Horizontal");
            dirY = Input.GetAxis("Vertical");
            transform.position += new Vector3(dirX * speed, dirY * speed, 0);
        }
        
    }
}
