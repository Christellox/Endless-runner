using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{

    public GameObject[] spawns = new GameObject[4];
    public GameObject[] cars = new GameObject[4];
    int s, c;
    bool uno, dos, tres, cuatro;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 6; i++)
        {
            s = Random.Range(0, 4);
            c = Random.Range(0, 4);
            if (s == 1 && !uno)
            {
                uno = true;
                Instantiate(cars[c], spawns[s].transform.position, spawns[s].transform.rotation);
            } else if (s==2 && !dos)
            {
                dos = true;
                Instantiate(cars[c], spawns[s].transform.position, spawns[s].transform.rotation);
            } else if (s == 3 && !tres)
            {
                tres = true;
                Instantiate(cars[c], spawns[s].transform.position, spawns[s].transform.rotation);
            } else if (s == 4 && !cuatro)
            {
                cuatro = true;
                Instantiate(cars[c], spawns[s].transform.position, spawns[s].transform.rotation);
            }

        }
    }

}
