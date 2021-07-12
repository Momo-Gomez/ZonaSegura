using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    
    public float speedY = 0.02f;
    public float speedX = 0.02f;
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
            transform.position += new Vector3(dirX * speedX, dirY * speedY, 0);
        }
        
    }
}
