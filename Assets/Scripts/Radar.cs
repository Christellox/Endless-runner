using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Radar : MonoBehaviour
{
    public int medida = 300;
    public GameObject pasajero;
    bool ocupado = false;

    public int puntos;
    public TMP_Text display_puntos;
    public int vida;
    public TMP_Text display_vida;
    public TMP_Text display_medida;

    public GameObject objetivos;

    public GameObject[] spawns = new GameObject[4];
    public GameObject coin;
    int s;
    public bool[] ocupados = {false, false, false, false};
    
    public GameObject[] spawnsAn = new GameObject[2];
    public GameObject[] spawnshp = new GameObject[4];
    public GameObject vaca;
    public GameObject corazon;
    public void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "People" || other.gameObject.tag == "nurse"){
            puntos = int.Parse(display_puntos.text) + 2;
            display_puntos.text = puntos.ToString();
            if(!ocupado){
            for(int i =  0; i < 4; i++) {
            s = Random.Range(0, 4);
            while(ocupados[s]){
                s = Random.Range(0, 4);
            }
            
            Instantiate(coin, 
            spawns[s].transform.position,
            spawns[s].transform.rotation); 
            ocupados[s] = true; 
            

        }
        for(int i =  0; i < 4; i++) {
            ocupados[i] = false;
        }
            }
         }

        
        if (other.gameObject.tag == "People" && !ocupado)
        {
            Destroy(other.gameObject);
            ocupado = true;
            pasajero.SetActive(true);
            objetivos.SetActive(true);

        }
        if (other.gameObject.tag == "nurse" && !ocupado)
        {
            Destroy(other.gameObject);
            ocupado = true;
            pasajero.SetActive(true);
            objetivos.SetActive(true);
            vida = int.Parse(display_vida.text) + 1;
            display_vida.text = vida.ToString();   

            for(int i =  0; i < 4; i++) {
            s = Random.Range(0, 4);
            while(ocupados[s]){
                s = Random.Range(0, 4);
            }
            
            Instantiate(corazon, 
            spawnshp[s].transform.position,
            spawnshp[s].transform.rotation); 
            ocupados[s] = true; 
            

            }
            for(int i =  0; i < 4; i++) {
                    ocupados[i] = false;
            }
        }

        if (other.gameObject.tag == "ghost" && !ocupado)
        {
            Destroy(other.gameObject);
            
            vida = int.Parse(display_vida.text) - 2;
            display_vida.text = vida.ToString();
            puntos = int.Parse(display_puntos.text) - 2;
            display_puntos.text = puntos.ToString(); 
        }
        if(other.gameObject.tag == "ghost" || other.gameObject.tag == "nurse"){
            for(int i =  0; i < 2; i++) {
            s = Random.Range(0, 2);
            while(ocupados[s]){
                s = Random.Range(0, 2);
            }
            
            Instantiate(vaca, 
            spawnsAn[s].transform.position,
            spawnsAn[s].transform.rotation); 
            ocupados[s] = true; 
            

            }
            for(int i =  0; i < 4; i++) {
                    ocupados[i] = false;
            }
        }

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            puntos = int.Parse(display_puntos.text) + 10;
            display_puntos.text = puntos.ToString();
        }
        if (other.gameObject.tag == "Cow")
        {
            Destroy(other.gameObject);
            puntos = int.Parse(display_puntos.text) - 10;
            display_puntos.text = puntos.ToString();
        }
        if (other.gameObject.tag == "hp")
        {
            Destroy(other.gameObject);
            vida = int.Parse(display_vida.text) + 1;
            display_vida.text = vida.ToString();
        }
        

    }

    void LateUpdate()
    {
        if(medida >= 0 && ocupado){
            display_medida.text = medida.ToString();
            medida--;
        }else{
            if(ocupado){
                pasajero.SetActive(false);
                objetivos.SetActive(false);
                ocupado = false;
                puntos++;
                display_puntos.text = puntos.ToString();
                medida = Random.Range(200, 500);
            }
            

        }
    }   
}
