using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject[] spawns = new GameObject[4];
    public GameObject coin;
    int s;
    public bool[] ocupados = {false, false, false, false};

    public bool ocupado = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "People" && !ocupado)
        ocupado = true;
        {
         for(int i =  0; i < 4; i++) {
            s = Random.Range(0, 4);
            while(ocupados[s]){
                s = Random.Range(0, 4);
            }
            
            Instantiate(coin, spawns[s].transform.position, spawns[s].transform.rotation); 
            ocupados[s] = true; 
            

        }
        for(int i =  0; i < 4; i++) {
            ocupados[i] = false;
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
