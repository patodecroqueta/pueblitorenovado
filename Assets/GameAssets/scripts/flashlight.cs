using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject imagenlinterna;
    void OnTriggerEnter(Collider c){
        print("En el trigger");
        if (c.gameObject.name=="Flashlight"){
            Destroy(c.gameObject);
            imagenlinterna.SetActive(true);
            GetComponent<Inventario>().AddItem(c.gameObject);
        }
    }
}