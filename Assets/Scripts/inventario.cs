using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventario : MonoBehaviour
{

    public List<GameObject> mochila = new List<GameObject>();
    public GameObject emergencias;
    public GameObject familia;
    public int buscarI(string item)
    {
        for (int i = 0; i < mochila.Count; i++)
        {
            if (mochila[i].gameObject.name == item)
            {
                return i;
            }
        }
        return -1;
    }

    public GameObject selector;
    public int id = 0;  

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Item")
        {
            
            for (int i = 0; i < mochila.Count; i++)
            {
                if (!mochila[i].GetComponent<Image>().IsActive())
                {
                    mochila[i].GetComponent<Image>().enabled = true;
                    mochila[i].GetComponent<Image>().sprite = collision.GetComponent<SpriteRenderer>().sprite;
                    mochila[i].name = collision.gameObject.name;
                    collision.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }

    public void navegar()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && id < mochila.Count-1)
        {
            id++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && id > 0)
        {
            id--;
        }

        selector.transform.position = mochila[id].transform.position;
    }

    public GameObject menuCelular;
    public GameObject selector1;
    public GameObject selector2;

    public void funcionCelular()
    {
        if (menuCelular.activeSelf == false && mochila[id].gameObject.name == "Celular" && Input.GetKeyDown(KeyCode.Q))
        {
            menuCelular.SetActive(true);
            selector1.SetActive(true);
        }
        else if (menuCelular.activeSelf == true && Input.GetKeyDown(KeyCode.Q))
        {
            menuCelular.SetActive(false);
        }
        else if (menuCelular.activeSelf == true && selector1.activeSelf == true && Input.GetKeyDown(KeyCode.DownArrow))
        {
            selector1.SetActive(false);
            selector2.SetActive(true);
        }
        else if (menuCelular.activeSelf == true && selector2.activeSelf == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            selector2.SetActive(false);
            selector1.SetActive(true);
        }
        else if (menuCelular.activeSelf == true && selector1.activeSelf == true && Input.GetKeyDown(KeyCode.F))
        {
            emergencias.SetActive(true);
        }
        else if (menuCelular.activeSelf == true && selector2.activeSelf == true && Input.GetKeyDown(KeyCode.F))
        {
            familia.SetActive(true);
        }

        if (buscarI("Celular") != id)
        {
            selector1.SetActive(false);
            selector2.SetActive(false);
            menuCelular.SetActive(false);
        }
    }
    
    private void Update()
    {
        navegar();
        funcionCelular();
    }
}
