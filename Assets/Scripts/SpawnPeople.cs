using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{

    public GameObject[] spawns = new GameObject[3];
    public GameObject[] people = new GameObject[5];
    int s, c;
    bool uno, dos, tres;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            s = Random.Range(0, 3);
            c = Random.Range(0, 5);
            if (s == 1 && !uno)
            {
                uno = true;
                Instantiate(people[c], spawns[s].transform.position, spawns[s].transform.rotation);
            }
            else if (s == 2 && !dos)
            {
                dos = true;
                Instantiate(people[c], spawns[s].transform.position, spawns[s].transform.rotation);
            }
            else if (s == 3 && !tres)
            {
                tres = true;
                Instantiate(people[c], spawns[s].transform.position, spawns[s].transform.rotation);
            }

        }
    }

}
