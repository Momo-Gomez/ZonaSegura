using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Notifiaciones : MonoBehaviour
{
    public GameObject panel;
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)){
               panel.SetActive(false);
            }
        }
}