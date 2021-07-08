using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    
    public float speed = 0.01f;
    public float dirX;
    public float dirY;

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        transform.position += new Vector3(dirX * speed, dirY * speed, 0);
    }
}
