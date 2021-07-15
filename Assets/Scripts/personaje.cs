using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{

    float speed = 1.2f;
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
            Vector3 newSpeed = new Vector3(dirX, dirY, 0);
            transform.Translate(newSpeed*Time.deltaTime*speed);
        }
    }
}