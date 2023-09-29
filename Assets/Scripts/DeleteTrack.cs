using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrack : MonoBehaviour
{
    public GameObject track;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(track, 1.0f);
        }
    }
}
