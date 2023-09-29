using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choque : MonoBehaviour
{
    public TMP_Text display_vida;
     public int vida;

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vehiculo")
        {
            Destroy(other.gameObject);
            vida = int.Parse(display_vida.text) - 5;
            display_vida.text = vida.ToString();
        }
        
    }
}
