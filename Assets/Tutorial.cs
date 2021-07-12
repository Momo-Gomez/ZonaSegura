using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public List<GameObject> tutorial = new List<GameObject>();
    int i = 0;
    void tuto (){
        while (i<tutorial.Count){
            tutorial[i].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space)){
                tutorial[i].SetActive(false);
                i++;
            }
        }
        
    }

    void Start()
    {
        tuto();
    }

}
