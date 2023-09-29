using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inicio : MonoBehaviour
{
     public GameObject inicio;


    public TMP_Text display_vida;
    public TMP_Text display_medida;

    public GameObject vidas;
    public GameObject puntos;
    
    public GameObject pvidas;
    public GameObject ppuntos;
    public void reiniciarJuego()
    {
        inicio.SetActive(false);

        
        // SceneManager.LoadScene(0);
        display_vida.text ="20";
        display_medida.text ="0";
        vidas.SetActive(true);
        puntos.SetActive(true);
        pvidas.SetActive(true);
        ppuntos.SetActive(true);

        
    }
}
