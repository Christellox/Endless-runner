using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject screen;
    public int vida;
    public TMP_Text display_vida;
    public GameObject inicio;

    // Update is called once per frame
    void Update()
    {
        vida = int.Parse(display_vida.text);
        if(vida <= 0 && !inicio.activeSelf){
            screen.SetActive(true);
        }
         
    }
}
