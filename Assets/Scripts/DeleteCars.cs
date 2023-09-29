using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCars : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vehiculo" || other.gameObject.tag == "People" 
        || other.gameObject.tag == "ghost" || other.gameObject.tag == "nurse" 
        || other.gameObject.tag == "Coin"
        || other.gameObject.tag == "Cow"
        || other.gameObject.tag == "hp"
        
        )
        {
            Destroy(other.gameObject);
        }
    }
}
