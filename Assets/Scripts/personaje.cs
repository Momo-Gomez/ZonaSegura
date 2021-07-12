using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    
    public float speedY = 0.02f;
    public float speedX = 0.02f;
    public float dirX;
    public float dirY;
    public bool estado;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log ("Obstaculo");

    } 
        
      void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        transform.position += new Vector3(dirX * speedX, dirY * speedY, 0);
    }
}
