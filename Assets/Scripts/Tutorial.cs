using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public List<GameObject> tutorial = new List<GameObject>();
    public GameObject tuto ;
    int i=0;
        
    void Start()
    {
        tutorial[i].SetActive(true);
    }
    private void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && (i+1)<tutorial.Count){
                tutorial[i].SetActive(false);
                tutorial[i+1].SetActive(true);
                i++;
            }
        else if (Input.GetKeyDown(KeyCode.Space) && i < tutorial.Count){
            tuto.SetActive(false);
            
        }
    }
}