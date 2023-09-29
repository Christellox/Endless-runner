using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrack : MonoBehaviour
{
    public GameObject track;
    public Transform spawn;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(track, spawn.position, spawn.rotation);
        }
    }
}
